using Generic = System.Collections.Generic;
using Http = System.Net.Http;
using Json = System.Text.Json;
using Linq = System.Linq;
using Specialized = System.Collections.Specialized;
using System = System;
using Text = System.Text;
using Web = System.Web;

namespace Anthropic;

public abstract record class ParamsBase
{
    public Generic::Dictionary<string, Json::JsonElement> QueryProperties { get; set; } = [];

    public Generic::Dictionary<string, Json::JsonElement> HeaderProperties { get; set; } = [];

    public abstract System::Uri Url(IAnthropicClient client);

    protected static void AddQueryElementToCollection(
        Specialized::NameValueCollection collection,
        string key,
        Json::JsonElement element
    )
    {
        switch (element.ValueKind)
        {
            case Json::JsonValueKind.Undefined:
            case Json::JsonValueKind.Null:
                collection.Add(key, "");
                break;
            case Json::JsonValueKind.String:
            case Json::JsonValueKind.Number:
                collection.Add(key, element.ToString());
                break;
            case Json::JsonValueKind.True:
                collection.Add(key, "true");
                break;
            case Json::JsonValueKind.False:
                collection.Add(key, "false");
                break;
            case Json::JsonValueKind.Object:
                foreach (var item in element.EnumerateObject())
                {
                    AddQueryElementToCollection(
                        collection,
                        string.Format("{0}[{1}]", key, item.Name),
                        item.Value
                    );
                }
                break;
            case Json::JsonValueKind.Array:
                collection.Add(
                    key,
                    string.Join(
                        ",",
                        Linq::Enumerable.Select(
                            element.EnumerateArray(),
                            x =>
                                x.ValueKind switch
                                {
                                    Json::JsonValueKind.Null => "",
                                    Json::JsonValueKind.True => "true",
                                    Json::JsonValueKind.False => "false",
                                    _ => x.GetString(),
                                }
                        )
                    )
                );
                break;
        }
    }

    protected static void AddHeaderElementToRequest(
        Http::HttpRequestMessage request,
        string key,
        Json::JsonElement element
    )
    {
        switch (element.ValueKind)
        {
            case Json::JsonValueKind.Undefined:
            case Json::JsonValueKind.Null:
                request.Headers.Add(key, "");
                break;
            case Json::JsonValueKind.String:
            case Json::JsonValueKind.Number:
                request.Headers.Add(key, element.ToString());
                break;
            case Json::JsonValueKind.True:
                request.Headers.Add(key, "true");
                break;
            case Json::JsonValueKind.False:
                request.Headers.Add(key, "false");
                break;
            case Json::JsonValueKind.Object:
                foreach (var item in element.EnumerateObject())
                {
                    AddHeaderElementToRequest(
                        request,
                        string.Format("{0}.{1}", key, item.Name),
                        item.Value
                    );
                }
                break;
            case Json::JsonValueKind.Array:
                foreach (var item in element.EnumerateArray())
                {
                    request.Headers.Add(
                        key,
                        item.ValueKind switch
                        {
                            Json::JsonValueKind.Null => "",
                            Json::JsonValueKind.True => "true",
                            Json::JsonValueKind.False => "false",
                            _ => item.GetString(),
                        }
                    );
                }
                break;
        }
    }

    protected string QueryString(IAnthropicClient client)
    {
        Specialized::NameValueCollection collection = [];
        foreach (var item in this.QueryProperties)
        {
            ParamsBase.AddQueryElementToCollection(collection, item.Key, item.Value);
        }
        Text::StringBuilder sb = new();
        bool first = true;
        foreach (var key in collection.AllKeys)
        {
            foreach (var value in collection.GetValues(key) ?? [])
            {
                if (!first)
                {
                    sb.Append('&');
                }
                first = false;
                sb.Append(Web::HttpUtility.UrlEncode(key));
                sb.Append('=');
                sb.Append(Web::HttpUtility.UrlEncode(value));
            }
        }
        return sb.ToString();
    }

    protected static void AddDefaultHeaders(
        Http::HttpRequestMessage request,
        IAnthropicClient client
    )
    {
        request.Headers.Add("X-Api-Key", client.APIKey);
        request.Headers.Add("Authorization", string.Format("Bearer {0}", client.AuthToken));
        request.Headers.Add("anthropic-version", "2023-06-01");
    }
}
