using Anthropic = Anthropic;
using Http = System.Net.Http;
using Json = System.Text.Json;
using System = System;

namespace Anthropic.Models.Messages.Batches;

/// <summary>
/// List all Message Batches within a Workspace. Most recently created batches are
/// returned first.
///
/// Learn more about the Message Batches API in our [user guide](/en/docs/build-with-claude/batch-processing)
/// </summary>
public sealed record class BatchListParams : Anthropic::ParamsBase
{
    /// <summary>
    /// ID of the object to use as a cursor for pagination. When provided, returns the
    /// page of results immediately after this object.
    /// </summary>
    public string? AfterID
    {
        get
        {
            if (!this.QueryProperties.TryGetValue("after_id", out Json::JsonElement element))
                return null;

            return Json::JsonSerializer.Deserialize<string?>(element);
        }
        set { this.QueryProperties["after_id"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// ID of the object to use as a cursor for pagination. When provided, returns the
    /// page of results immediately before this object.
    /// </summary>
    public string? BeforeID
    {
        get
        {
            if (!this.QueryProperties.TryGetValue("before_id", out Json::JsonElement element))
                return null;

            return Json::JsonSerializer.Deserialize<string?>(element);
        }
        set { this.QueryProperties["before_id"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// Number of items to return per page.
    ///
    /// Defaults to `20`. Ranges from `1` to `1000`.
    /// </summary>
    public long? Limit
    {
        get
        {
            if (!this.QueryProperties.TryGetValue("limit", out Json::JsonElement element))
                return null;

            return Json::JsonSerializer.Deserialize<long?>(element);
        }
        set { this.QueryProperties["limit"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override System::Uri Url(Anthropic::IAnthropicClient client)
    {
        return new System::UriBuilder(
            client.BaseUrl.ToString().TrimEnd('/') + "/v1/messages/batches"
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
