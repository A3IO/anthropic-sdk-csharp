using Anthropic = Anthropic;
using Beta = Anthropic.Models.Beta;
using Generic = System.Collections.Generic;
using Http = System.Net.Http;
using Json = System.Text.Json;
using System = System;

namespace Anthropic.Models.Beta.Messages.Batches;

/// <summary>
/// This endpoint is idempotent and can be used to poll for Message Batch completion.
/// To access the results of a Message Batch, make a request to the `results_url`
/// field in the response.
///
/// Learn more about the Message Batches API in our [user guide](/en/docs/build-with-claude/batch-processing)
/// </summary>
public sealed record class BatchRetrieveParams : Anthropic::ParamsBase
{
    public required string MessageBatchID;

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
            client.BaseUrl.ToString().TrimEnd('/')
                + string.Format("/v1/messages/batches/{0}?beta=true", this.MessageBatchID)
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
