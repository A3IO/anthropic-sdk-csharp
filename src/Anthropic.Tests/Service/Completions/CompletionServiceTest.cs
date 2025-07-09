using Beta = Anthropic.Models.Beta;
using Completions = Anthropic.Models.Completions;
using Messages = Anthropic.Models.Messages;
using Tasks = System.Threading.Tasks;
using Tests = Anthropic.Tests;

namespace Anthropic.Tests.Service.Completions;

public class CompletionServiceTest : Tests::TestBase
{
    [Fact]
    public async Tasks::Task Create_Works()
    {
        var completion = await this.client.Completions.Create(
            new Completions::CompletionCreateParams()
            {
                MaxTokensToSample = 256,
                Model = Messages::Model.Claude3_7SonnetLatest,
                Prompt = "\n\nHuman: Hello, world!\n\nAssistant:",
                Metadata = new Messages::Metadata()
                {
                    UserID = "13803d75-b4b5-4c3e-b2a2-6f21399b021b",
                },
                StopSequences = ["string"],
                Stream = true,
                Temperature = 1,
                TopK = 5,
                TopP = 0.7,
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        completion.Validate();
    }
}
