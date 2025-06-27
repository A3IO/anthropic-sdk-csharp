using Anthropic = Anthropic;
using Beta = Anthropic.Models.Beta;
using Generic = System.Collections.Generic;
using Http = System.Net.Http;
using Json = System.Text.Json;
using System = System;

namespace Anthropic.Models.Beta.Messages.Batches;

/// <summary>
/// Streams the results of a Message Batch as a `.jsonl` file.
///
/// Each line in the file is a JSON object containing the result of a single request
/// in the Message Batch. Results are not guaranteed to be in the same order as requests.
/// Use the `custom_id` field to match results to requests.
///
/// Learn more about the Message Batches API in our [user guide](/en/docs/build-with-claude/batch-processing)
/// </summary>
public sealed record class BatchResultsParams : Anthropic::ParamsBase
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
                + string.Format("/v1/messages/batches/{0}/results?beta=true", this.MessageBatchID)
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
