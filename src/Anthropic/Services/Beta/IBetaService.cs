using Files = Anthropic.Services.Beta.Files;
using Messages = Anthropic.Services.Beta.Messages;
using Models = Anthropic.Services.Beta.Models;

namespace Anthropic.Services.Beta;

public interface IBetaService
{
    Models::IModelService Models { get; }

    Messages::IMessageService Messages { get; }

    Files::IFileService Files { get; }
}
