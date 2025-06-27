using Anthropic = Anthropic;
using Beta = Anthropic.Models.Beta;
using Generic = System.Collections.Generic;
using Http = System.Net.Http;
using Json = System.Text.Json;
using System = System;

namespace Anthropic.Models.Beta.Files;

/// <summary>
/// Download File
/// </summary>
public sealed record class FileDownloadParams : Anthropic::ParamsBase
{
    public required string FileID;

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
                + string.Format("/v1/files/{0}/content?beta=true", this.FileID)
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
