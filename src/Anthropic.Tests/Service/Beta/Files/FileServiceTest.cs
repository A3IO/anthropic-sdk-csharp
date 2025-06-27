using Anthropic = Anthropic;
using Beta = Anthropic.Models.Beta;
using Files = Anthropic.Models.Beta.Files;
using System = System;
using Tasks = System.Threading.Tasks;

namespace Anthropic.Tests.Service.Beta.Files;

public class FileServiceTest
{
    [Fact]
    public async Tasks::Task List_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var page = await client.Beta.Files.List(
            new Files::FileListParams()
            {
                AfterID = "after_id",
                BeforeID = "before_id",
                Limit = 1,
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        page.Validate();
    }

    [Fact]
    public async Tasks::Task Delete_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var deletedFile = await client.Beta.Files.Delete(
            new Files::FileDeleteParams()
            {
                FileID = "file_id",
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        deletedFile.Validate();
    }

    [Fact]
    public async Tasks::Task Download_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        await client.Beta.Files.Download(
            new Files::FileDownloadParams()
            {
                FileID = "file_id",
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
    }

    [Fact]
    public async Tasks::Task RetrieveMetadata_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var fileMetadata = await client.Beta.Files.RetrieveMetadata(
            new Files::FileRetrieveMetadataParams()
            {
                FileID = "file_id",
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        fileMetadata.Validate();
    }

    [Fact]
    public async Tasks::Task Upload_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var fileMetadata = await client.Beta.Files.Upload(
            new Files::FileUploadParams()
            {
                File = "a value",
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        fileMetadata.Validate();
    }
}
