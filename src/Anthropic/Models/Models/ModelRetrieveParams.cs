using Anthropic = Anthropic;
using Beta = Anthropic.Models.Beta;
using Generic = System.Collections.Generic;
using Http = System.Net.Http;
using Json = System.Text.Json;
using System = System;

namespace Anthropic.Models.Models;

/// <summary>
/// Get a specific model.
///
/// The Models API response can be used to determine information about a specific
/// model or resolve a model alias to a model ID.
/// </summary>
public sealed record class ModelRetrieveParams : Anthropic::ParamsBase
{
    public required string ModelID;

    /// <summary>
    /// Optional header to specify the beta version(s) you want to use.
    /// </summary>
    public Generic::List<Beta::AnthropicBeta>? Betas
    {
        get
        {
            if (!this.HeaderProperties.TryGetValue("betas", out Json::JsonElement element))
                return null;

            return Json::JsonSerializer.Deserialize<Generic::List<Beta::AnthropicBeta>?>(element);
        }
        set { this.HeaderProperties["betas"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override System::Uri Url(Anthropic::IAnthropicClient client)
    {
        return new System::UriBuilder(
            client.BaseUrl.ToString().TrimEnd('/') + string.Format("/v1/models/{0}", this.ModelID)
        )
        {
            Query = this.QueryString(client),
        }.Uri;
    }

    public void AddHeadersToRequest(
        Http::HttpRequestMessage request,
        Anthropic::IAnthropicClient client
    )
    {
        Anthropic::ParamsBase.AddDefaultHeaders(request, client);
        foreach (var item in this.HeaderProperties)
        {
            Anthropic::ParamsBase.AddHeaderElementToRequest(request, item.Key, item.Value);
        }
    }
}
