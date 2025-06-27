using Files = Anthropic.Service.Beta.Files;
using Messages = Anthropic.Service.Beta.Messages;
using Models = Anthropic.Service.Beta.Models;

namespace Anthropic.Service.Beta;

public interface IBetaService
{
    Models::IModelService Models { get; }

    Messages::IMessageService Messages { get; }

    Files::IFileService Files { get; }
}
