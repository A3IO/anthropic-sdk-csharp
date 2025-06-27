using Beta = Anthropic.Service.Beta;
using Completions = Anthropic.Service.Completions;
using Http = System.Net.Http;
using Messages = Anthropic.Service.Messages;
using Models = Anthropic.Service.Models;
using System = System;

namespace Anthropic;

public interface IAnthropicClient
{
    Http::HttpClient HttpClient { get; init; }

    System::Uri BaseUrl { get; init; }

    string APIKey { get; init; }

    string AuthToken { get; init; }

    Completions::ICompletionService Completions { get; }

    Messages::IMessageService Messages { get; }

    Models::IModelService Models { get; }

    Beta::IBetaService Beta { get; }
}
