using Anthropic = Anthropic;
using Completions = Anthropic.Models.Completions;
using Http = System.Net.Http;
using Json = System.Text.Json;
using System = System;
using Tasks = System.Threading.Tasks;

namespace Anthropic.Service.Completions;

public sealed class CompletionService : ICompletionService
{
    readonly Anthropic::IAnthropicClient _client;

    public CompletionService(Anthropic::IAnthropicClient client)
    {
        _client = client;
    }

    public async Tasks::Task<Completions::Completion> Create(
        Completions::CompletionCreateParams @params
    )
    {
        Http::HttpRequestMessage webRequest = new(Http::HttpMethod.Post, @params.Url(this._client))
        {
            Content = @params.BodyContent(),
        };
        @params.AddHeadersToRequest(webRequest, this._client);
        using Http::HttpResponseMessage response = await _client.HttpClient.SendAsync(webRequest);
        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (Http::HttpRequestException e)
        {
            throw new Anthropic::HttpException(
                e.StatusCode,
                await response.Content.ReadAsStringAsync()
            );
        }
        return Json::JsonSerializer.Deserialize<Completions::Completion>(
                await response.Content.ReadAsStringAsync()
            ) ?? throw new System::NullReferenceException();
    }
}
