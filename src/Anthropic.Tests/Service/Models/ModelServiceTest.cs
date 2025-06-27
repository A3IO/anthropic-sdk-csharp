using Anthropic = Anthropic;
using Beta = Anthropic.Models.Beta;
using Models = Anthropic.Models.Models;
using System = System;
using Tasks = System.Threading.Tasks;

namespace Anthropic.Tests.Service.Models;

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
        var modelInfo = await client.Models.Retrieve(
            new Models::ModelRetrieveParams()
            {
                ModelID = "model_id",
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        modelInfo.Validate();
    }

    [Fact]
    public async Tasks::Task List_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var page = await client.Models.List(
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
