using System.Threading.Tasks;
using Anthropic.Models.Messages;

namespace Anthropic.Tests.Services.Completions;

public class CompletionServiceTest : TestBase
{
    [Fact]
    public async Task Create_Works()
    {
        var completion = await this.client.Completions.Create(
            new()
            {
                MaxTokensToSample = 256,
                Model = Model.Claude3_7SonnetLatest,
                Prompt = "\n\nHuman: Hello, world!\n\nAssistant:",
            }
        );
        completion.Validate();
    }

    [Fact]
    public async Task CreateStreaming_Works()
    {
        var stream = this.client.Completions.CreateStreaming(
            new()
            {
                MaxTokensToSample = 256,
                Model = Model.Claude3_7SonnetLatest,
                Prompt = "\n\nHuman: Hello, world!\n\nAssistant:",
            }
        );

        await foreach (var completion in stream)
        {
            completion.Validate();
        }
    }
}
