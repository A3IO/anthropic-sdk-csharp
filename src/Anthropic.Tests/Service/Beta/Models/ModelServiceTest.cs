using Anthropic = Anthropic;
using Beta = Anthropic.Models.Beta;
using Models = Anthropic.Models.Beta.Models;
using System = System;
using Tasks = System.Threading.Tasks;

namespace Anthropic.Tests.Service.Beta.Models;

public class ModelServiceTest
{
    [Fact]
    public async Tasks::Task Retrieve_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var betaModelInfo = await client.Beta.Models.Retrieve(
            new Models::ModelRetrieveParams()
            {
                ModelID = "model_id",
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        betaModelInfo.Validate();
    }

    [Fact]
    public async Tasks::Task List_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var page = await client.Beta.Models.List(
            new Models::ModelListParams()
            {
                AfterID = "after_id",
                BeforeID = "before_id",
                Limit = 1,
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        page.Validate();
    }
}
