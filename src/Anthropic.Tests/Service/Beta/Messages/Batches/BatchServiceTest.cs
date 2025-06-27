using Anthropic = Anthropic;
using BatchCreateParamsProperties = Anthropic.Models.Beta.Messages.Batches.BatchCreateParamsProperties;
using Batches = Anthropic.Models.Beta.Messages.Batches;
using Beta = Anthropic.Models.Beta;
using BetaCacheControlEphemeralProperties = Anthropic.Models.Beta.Messages.BetaCacheControlEphemeralProperties;
using BetaCitationCharLocationParamProperties = Anthropic.Models.Beta.Messages.BetaCitationCharLocationParamProperties;
using BetaMessageParamProperties = Anthropic.Models.Beta.Messages.BetaMessageParamProperties;
using BetaRequestMCPServerURLDefinitionProperties = Anthropic.Models.Beta.Messages.BetaRequestMCPServerURLDefinitionProperties;
using BetaTextBlockParamProperties = Anthropic.Models.Beta.Messages.BetaTextBlockParamProperties;
using BetaThinkingConfigEnabledProperties = Anthropic.Models.Beta.Messages.BetaThinkingConfigEnabledProperties;
using BetaToolChoiceAutoProperties = Anthropic.Models.Beta.Messages.BetaToolChoiceAutoProperties;
using BetaToolProperties = Anthropic.Models.Beta.Messages.BetaToolProperties;
using InputSchemaProperties = Anthropic.Models.Beta.Messages.BetaToolProperties.InputSchemaProperties;
using Json = System.Text.Json;
using Messages = Anthropic.Models.Beta.Messages;
using Messages1 = Anthropic.Models.Messages;
using ParamsProperties = Anthropic.Models.Beta.Messages.Batches.BatchCreateParamsProperties.RequestProperties.ParamsProperties;
using RequestProperties = Anthropic.Models.Beta.Messages.Batches.BatchCreateParamsProperties.RequestProperties;
using System = System;
using Tasks = System.Threading.Tasks;

namespace Anthropic.Tests.Service.Beta.Messages.Batches;

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
        var betaMessageBatch = await client.Beta.Messages.Batches.Create(
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
                                new Messages::BetaMessageParam()
                                {
                                    Content = BetaMessageParamProperties::Content.Create(
                                        "Hello, world"
                                    ),
                                    Role = BetaMessageParamProperties::Role.User,
                                },
                            ],
                            Model = Messages1::Model.Claude3_7SonnetLatest,
                            Container = "container",
                            MCPServers =
                            [
                                new Messages::BetaRequestMCPServerURLDefinition()
                                {
                                    Name = "name",
                                    Type = BetaRequestMCPServerURLDefinitionProperties::Type.URL,
                                    URL = "url",
                                    AuthorizationToken = "authorization_token",
                                    ToolConfiguration =
                                        new Messages::BetaRequestMCPServerToolConfiguration()
                                        {
                                            AllowedTools = ["string"],
                                            Enabled = true,
                                        },
                                },
                            ],
                            Metadata = new Messages::BetaMetadata()
                            {
                                UserID = "13803d75-b4b5-4c3e-b2a2-6f21399b021b",
                            },
                            ServiceTier = ParamsProperties::ServiceTier.Auto,
                            StopSequences = ["string"],
                            Stream = true,
                            System = ParamsProperties::System.Create(
                                [
                                    new Messages::BetaTextBlockParam()
                                    {
                                        Text = "Today's date is 2024-06-01.",
                                        Type = BetaTextBlockParamProperties::Type.Text,
                                        CacheControl = new Messages::BetaCacheControlEphemeral()
                                        {
                                            Type =
                                                BetaCacheControlEphemeralProperties::Type.Ephemeral,
                                            TTL = BetaCacheControlEphemeralProperties::TTL.TTL5m,
                                        },
                                        Citations =
                                        [
                                            Messages::BetaTextCitationParam.Create(
                                                new Messages::BetaCitationCharLocationParam()
                                                {
                                                    CitedText = "cited_text",
                                                    DocumentIndex = 0,
                                                    DocumentTitle = "x",
                                                    EndCharIndex = 0,
                                                    StartCharIndex = 0,
                                                    Type =
                                                        BetaCitationCharLocationParamProperties::Type.CharLocation,
                                                }
                                            ),
                                        ],
                                    },
                                ]
                            ),
                            Temperature = 1,
                            Thinking = Messages::BetaThinkingConfigParam.Create(
                                new Messages::BetaThinkingConfigEnabled()
                                {
                                    BudgetTokens = 1024,
                                    Type = BetaThinkingConfigEnabledProperties::Type.Enabled,
                                }
                            ),
                            ToolChoice = Messages::BetaToolChoice.Create(
                                new Messages::BetaToolChoiceAuto()
                                {
                                    Type = BetaToolChoiceAutoProperties::Type.Auto,
                                    DisableParallelToolUse = true,
                                }
                            ),
                            Tools =
                            [
                                Messages::BetaToolUnion.Create(
                                    new Messages::BetaTool()
                                    {
                                        InputSchema = new BetaToolProperties::InputSchema()
                                        {
                                            Type = InputSchemaProperties::Type.Object,
                                            Properties1 =
                                                Json::JsonSerializer.Deserialize<Json::JsonElement>(
                                                    "{\"location\":{\"description\":\"The city and state, e.g. San Francisco, CA\",\"type\":\"string\"},\"unit\":{\"description\":\"Unit for the output - one of (celsius, fahrenheit)\",\"type\":\"string\"}}"
                                                ),
                                            Required = ["location"],
                                        },
                                        Name = "name",
                                        CacheControl = new Messages::BetaCacheControlEphemeral()
                                        {
                                            Type =
                                                BetaCacheControlEphemeralProperties::Type.Ephemeral,
                                            TTL = BetaCacheControlEphemeralProperties::TTL.TTL5m,
                                        },
                                        Description = "Get the current weather in a given location",
                                        Type = BetaToolProperties::Type.Custom,
                                    }
                                ),
                            ],
                            TopK = 5,
                            TopP = 0.7,
                        },
                    },
                ],
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        betaMessageBatch.Validate();
    }

    [Fact]
    public async Tasks::Task Retrieve_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var betaMessageBatch = await client.Beta.Messages.Batches.Retrieve(
            new Batches::BatchRetrieveParams()
            {
                MessageBatchID = "message_batch_id",
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        betaMessageBatch.Validate();
    }

    [Fact]
    public async Tasks::Task List_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var page = await client.Beta.Messages.Batches.List(
            new Batches::BatchListParams()
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
        var betaDeletedMessageBatch = await client.Beta.Messages.Batches.Delete(
            new Batches::BatchDeleteParams()
            {
                MessageBatchID = "message_batch_id",
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        betaDeletedMessageBatch.Validate();
    }

    [Fact]
    public async Tasks::Task Cancel_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var betaMessageBatch = await client.Beta.Messages.Batches.Cancel(
            new Batches::BatchCancelParams()
            {
                MessageBatchID = "message_batch_id",
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        betaMessageBatch.Validate();
    }

    [Fact]
    public async Tasks::Task Results_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var betaMessageBatchIndividualResponse = await client.Beta.Messages.Batches.Results(
            new Batches::BatchResultsParams()
            {
                MessageBatchID = "message_batch_id",
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        betaMessageBatchIndividualResponse.Validate();
    }
}
