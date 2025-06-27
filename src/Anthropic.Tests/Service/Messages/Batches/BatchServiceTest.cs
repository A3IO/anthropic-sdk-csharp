using Anthropic = Anthropic;
using BatchCreateParamsProperties = Anthropic.Models.Messages.Batches.BatchCreateParamsProperties;
using Batches = Anthropic.Models.Messages.Batches;
using CacheControlEphemeralProperties = Anthropic.Models.Messages.CacheControlEphemeralProperties;
using CitationCharLocationParamProperties = Anthropic.Models.Messages.CitationCharLocationParamProperties;
using InputSchemaProperties = Anthropic.Models.Messages.ToolProperties.InputSchemaProperties;
using Json = System.Text.Json;
using MessageParamProperties = Anthropic.Models.Messages.MessageParamProperties;
using Messages = Anthropic.Models.Messages;
using ParamsProperties = Anthropic.Models.Messages.Batches.BatchCreateParamsProperties.RequestProperties.ParamsProperties;
using RequestProperties = Anthropic.Models.Messages.Batches.BatchCreateParamsProperties.RequestProperties;
using System = System;
using Tasks = System.Threading.Tasks;
using TextBlockParamProperties = Anthropic.Models.Messages.TextBlockParamProperties;
using ThinkingConfigEnabledProperties = Anthropic.Models.Messages.ThinkingConfigEnabledProperties;
using ToolChoiceAutoProperties = Anthropic.Models.Messages.ToolChoiceAutoProperties;
using ToolProperties = Anthropic.Models.Messages.ToolProperties;

namespace Anthropic.Tests.Service.Messages.Batches;

public class BatchServiceTest
{
    [Fact]
    public async Tasks::Task Create_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var messageBatch = await client.Messages.Batches.Create(
            new Batches::BatchCreateParams()
            {
                Requests =
                [
                    new BatchCreateParamsProperties::Request()
                    {
                        CustomID = "my-custom-id-1",
                        Params = new RequestProperties::Params()
                        {
                            MaxTokens = 1024,
                            Messages =
                            [
                                new Messages::MessageParam()
                                {
                                    Content = MessageParamProperties::Content.Create(
                                        "Hello, world"
                                    ),
                                    Role = MessageParamProperties::Role.User,
                                },
                            ],
                            Model = Messages::Model.Claude3_7SonnetLatest,
                            Metadata = new Messages::Metadata()
                            {
                                UserID = "13803d75-b4b5-4c3e-b2a2-6f21399b021b",
                            },
                            ServiceTier = ParamsProperties::ServiceTier.Auto,
                            StopSequences = ["string"],
                            Stream = true,
                            System = ParamsProperties::System.Create(
                                [
                                    new Messages::TextBlockParam()
                                    {
                                        Text = "Today's date is 2024-06-01.",
                                        Type = TextBlockParamProperties::Type.Text,
                                        CacheControl = new Messages::CacheControlEphemeral()
                                        {
                                            Type = CacheControlEphemeralProperties::Type.Ephemeral,
                                        },
                                        Citations =
                                        [
                                            Messages::TextCitationParam.Create(
                                                new Messages::CitationCharLocationParam()
                                                {
                                                    CitedText = "cited_text",
                                                    DocumentIndex = 0,
                                                    DocumentTitle = "x",
                                                    EndCharIndex = 0,
                                                    StartCharIndex = 0,
                                                    Type =
                                                        CitationCharLocationParamProperties::Type.CharLocation,
                                                }
                                            ),
                                        ],
                                    },
                                ]
                            ),
                            Temperature = 1,
                            Thinking = Messages::ThinkingConfigParam.Create(
                                new Messages::ThinkingConfigEnabled()
                                {
                                    BudgetTokens = 1024,
                                    Type = ThinkingConfigEnabledProperties::Type.Enabled,
                                }
                            ),
                            ToolChoice = Messages::ToolChoice.Create(
                                new Messages::ToolChoiceAuto()
                                {
                                    Type = ToolChoiceAutoProperties::Type.Auto,
                                    DisableParallelToolUse = true,
                                }
                            ),
                            Tools =
                            [
                                Messages::ToolUnion.Create(
                                    new Messages::Tool()
                                    {
                                        InputSchema = new ToolProperties::InputSchema()
                                        {
                                            Type = InputSchemaProperties::Type.Object,
                                            Properties1 =
                                                Json::JsonSerializer.Deserialize<Json::JsonElement>(
                                                    "{\"location\":{\"description\":\"The city and state, e.g. San Francisco, CA\",\"type\":\"string\"},\"unit\":{\"description\":\"Unit for the output - one of (celsius, fahrenheit)\",\"type\":\"string\"}}"
                                                ),
                                            Required = ["location"],
                                        },
                                        Name = "name",
                                        CacheControl = new Messages::CacheControlEphemeral()
                                        {
                                            Type = CacheControlEphemeralProperties::Type.Ephemeral,
                                        },
                                        Description = "Get the current weather in a given location",
                                        Type = ToolProperties::Type.Custom,
                                    }
                                ),
                            ],
                            TopK = 5,
                            TopP = 0.7,
                        },
                    },
                ],
            }
        );
        messageBatch.Validate();
    }

    [Fact]
    public async Tasks::Task Retrieve_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var messageBatch = await client.Messages.Batches.Retrieve(
            new Batches::BatchRetrieveParams() { MessageBatchID = "message_batch_id" }
        );
        messageBatch.Validate();
    }

    [Fact]
    public async Tasks::Task List_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var page = await client.Messages.Batches.List(
            new Batches::BatchListParams()
            {
                AfterID = "after_id",
                BeforeID = "before_id",
                Limit = 1,
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
        var deletedMessageBatch = await client.Messages.Batches.Delete(
            new Batches::BatchDeleteParams() { MessageBatchID = "message_batch_id" }
        );
        deletedMessageBatch.Validate();
    }

    [Fact]
    public async Tasks::Task Cancel_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var messageBatch = await client.Messages.Batches.Cancel(
            new Batches::BatchCancelParams() { MessageBatchID = "message_batch_id" }
        );
        messageBatch.Validate();
    }

    [Fact]
    public async Tasks::Task Results_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var messageBatchIndividualResponse = await client.Messages.Batches.Results(
            new Batches::BatchResultsParams() { MessageBatchID = "message_batch_id" }
        );
        messageBatchIndividualResponse.Validate();
    }
}
