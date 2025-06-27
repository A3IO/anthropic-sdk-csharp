using Anthropic = Anthropic;
using Files = Anthropic.Service.Beta.Files;
using Messages = Anthropic.Service.Beta.Messages;
using Models = Anthropic.Service.Beta.Models;
using System = System;

namespace Anthropic.Service.Beta;

public sealed class BetaService : IBetaService
{
    public BetaService(Anthropic::IAnthropicClient client)
    {
        _models = new(() => new Models::ModelService(client));
        _messages = new(() => new Messages::MessageService(client));
        _files = new(() => new Files::FileService(client));
    }

    readonly System::Lazy<Models::IModelService> _models;
    public Models::IModelService Models
    {
        get { return _models.Value; }
    }

    readonly System::Lazy<Messages::IMessageService> _messages;
    public Messages::IMessageService Messages
    {
        get { return _messages.Value; }
    }

    readonly System::Lazy<Files::IFileService> _files;
    public Files::IFileService Files
    {
        get { return _files.Value; }
    }
}
