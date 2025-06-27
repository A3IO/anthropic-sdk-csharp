using Anthropic = Anthropic;
using Beta = Anthropic.Models.Beta;
using Generic = System.Collections.Generic;
using Http = System.Net.Http;
using Json = System.Text.Json;
using System = System;

namespace Anthropic.Models.Beta.Messages.Batches;

/// <summary>
/// Delete a Message Batch.
///
/// Message Batches can only be deleted once they've finished processing. If you'd
/// like to delete an in-progress batch, you must first cancel it.
///
/// Learn more about the Message Batches API in our [user guide](/en/docs/build-with-claude/batch-processing)
/// </summary>
public sealed record class BatchDeleteParams : Anthropic::ParamsBase
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
