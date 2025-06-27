using Anthropic = Anthropic;
using Batches = Anthropic.Service.Beta.Messages.Batches;
using Http = System.Net.Http;
using Json = System.Text.Json;
using Messages = Anthropic.Models.Beta.Messages;
using System = System;
using Tasks = System.Threading.Tasks;

namespace Anthropic.Service.Beta.Messages;

public sealed class MessageService : IMessageService
{
    readonly Anthropic::IAnthropicClient _client;

    public MessageService(Anthropic::IAnthropicClient client)
    {
        _client = client;
        _batches = new(() => new Batches::BatchService(client));
    }

    readonly System::Lazy<Batches::IBatchService> _batches;
    public Batches::IBatchService Batches
    {
        get { return _batches.Value; }
    }

    public async Tasks::Task<Messages::BetaMessage> Create(Messages::MessageCreateParams @params)
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
        return Json::JsonSerializer.Deserialize<Messages::BetaMessage>(
                await response.Content.ReadAsStringAsync()
            ) ?? throw new System::NullReferenceException();
    }

    public async Tasks::Task<Messages::BetaMessageTokensCount> CountTokens(
        Messages::MessageCountTokensParams @params
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
        return Json::JsonSerializer.Deserialize<Messages::BetaMessageTokensCount>(
                await response.Content.ReadAsStringAsync()
            ) ?? throw new System::NullReferenceException();
    }
}
