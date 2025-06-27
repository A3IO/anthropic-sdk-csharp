using Anthropic = Anthropic;
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
using MessageCountTokensParamsProperties = Anthropic.Models.Beta.Messages.MessageCountTokensParamsProperties;
using MessageCreateParamsProperties = Anthropic.Models.Beta.Messages.MessageCreateParamsProperties;
using Messages = Anthropic.Models.Messages;
using Messages1 = Anthropic.Models.Beta.Messages;
using System = System;
using Tasks = System.Threading.Tasks;

namespace Anthropic.Tests.Service.Beta.Messages;

public class MessageServiceTest
{
    [Fact]
    public async Tasks::Task Create_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var betaMessage = await client.Beta.Messages.Create(
            new Messages1::MessageCreateParams()
            {
                MaxTokens = 1024,
                Messages =
                [
                    new Messages1::BetaMessageParam()
                    {
                        Content = BetaMessageParamProperties::Content.Create("string"),
                        Role = BetaMessageParamProperties::Role.User,
                    },
                ],
                Model = Messages::Model.Claude3_7SonnetLatest,
                Container = "container",
                MCPServers =
                [
                    new Messages1::BetaRequestMCPServerURLDefinition()
                    {
                        Name = "name",
                        Type = BetaRequestMCPServerURLDefinitionProperties::Type.URL,
                        URL = "url",
                        AuthorizationToken = "authorization_token",
                        ToolConfiguration = new Messages1::BetaRequestMCPServerToolConfiguration()
                        {
                            AllowedTools = ["string"],
                            Enabled = true,
                        },
                    },
                ],
                Metadata = new Messages1::BetaMetadata()
                {
                    UserID = "13803d75-b4b5-4c3e-b2a2-6f21399b021b",
                },
                ServiceTier = MessageCreateParamsProperties::ServiceTier.Auto,
                StopSequences = ["string"],
                Stream = true,
                System = MessageCreateParamsProperties::System.Create(
                    [
                        new Messages1::BetaTextBlockParam()
                        {
                            Text = "Today's date is 2024-06-01.",
                            Type = BetaTextBlockParamProperties::Type.Text,
                            CacheControl = new Messages1::BetaCacheControlEphemeral()
                            {
                                Type = BetaCacheControlEphemeralProperties::Type.Ephemeral,
                                TTL = BetaCacheControlEphemeralProperties::TTL.TTL5m,
                            },
                            Citations =
                            [
                                Messages1::BetaTextCitationParam.Create(
                                    new Messages1::BetaCitationCharLocationParam()
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
                Thinking = Messages1::BetaThinkingConfigParam.Create(
                    new Messages1::BetaThinkingConfigEnabled()
                    {
                        BudgetTokens = 1024,
                        Type = BetaThinkingConfigEnabledProperties::Type.Enabled,
                    }
                ),
                ToolChoice = Messages1::BetaToolChoice.Create(
                    new Messages1::BetaToolChoiceAuto()
                    {
                        Type = BetaToolChoiceAutoProperties::Type.Auto,
                        DisableParallelToolUse = true,
                    }
                ),
                Tools =
                [
                    Messages1::BetaToolUnion.Create(
                        new Messages1::BetaTool()
                        {
                            InputSchema = new BetaToolProperties::InputSchema()
                            {
                                Type = InputSchemaProperties::Type.Object,
                                Properties1 = Json::JsonSerializer.Deserialize<Json::JsonElement>(
                                    "{\"location\":{\"description\":\"The city and state, e.g. San Francisco, CA\",\"type\":\"string\"},\"unit\":{\"description\":\"Unit for the output - one of (celsius, fahrenheit)\",\"type\":\"string\"}}"
                                ),
                                Required = ["location"],
                            },
                            Name = "name",
                            CacheControl = new Messages1::BetaCacheControlEphemeral()
                            {
                                Type = BetaCacheControlEphemeralProperties::Type.Ephemeral,
                                TTL = BetaCacheControlEphemeralProperties::TTL.TTL5m,
                            },
                            Description = "Get the current weather in a given location",
                            Type = BetaToolProperties::Type.Custom,
                        }
                    ),
                ],
                TopK = 5,
                TopP = 0.7,
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        betaMessage.Validate();
    }

    [Fact]
    public async Tasks::Task CountTokens_Works()
    {
        Anthropic::IAnthropicClient client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri("http://localhost:4010"),
            APIKey = "my-anthropic-api-key",
        };
        var betaMessageTokensCount = await client.Beta.Messages.CountTokens(
            new Messages1::MessageCountTokensParams()
            {
                Messages =
                [
                    new Messages1::BetaMessageParam()
                    {
                        Content = BetaMessageParamProperties::Content.Create("string"),
                        Role = BetaMessageParamProperties::Role.User,
                    },
                ],
                Model = Messages::Model.Claude3_7SonnetLatest,
                MCPServers =
                [
                    new Messages1::BetaRequestMCPServerURLDefinition()
                    {
                        Name = "name",
                        Type = BetaRequestMCPServerURLDefinitionProperties::Type.URL,
                        URL = "url",
                        AuthorizationToken = "authorization_token",
                        ToolConfiguration = new Messages1::BetaRequestMCPServerToolConfiguration()
                        {
                            AllowedTools = ["string"],
                            Enabled = true,
                        },
                    },
                ],
                System = MessageCountTokensParamsProperties::System.Create(
                    [
                        new Messages1::BetaTextBlockParam()
                        {
                            Text = "Today's date is 2024-06-01.",
                            Type = BetaTextBlockParamProperties::Type.Text,
                            CacheControl = new Messages1::BetaCacheControlEphemeral()
                            {
                                Type = BetaCacheControlEphemeralProperties::Type.Ephemeral,
                                TTL = BetaCacheControlEphemeralProperties::TTL.TTL5m,
                            },
                            Citations =
                            [
                                Messages1::BetaTextCitationParam.Create(
                                    new Messages1::BetaCitationCharLocationParam()
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
                Thinking = Messages1::BetaThinkingConfigParam.Create(
                    new Messages1::BetaThinkingConfigEnabled()
                    {
                        BudgetTokens = 1024,
                        Type = BetaThinkingConfigEnabledProperties::Type.Enabled,
                    }
                ),
                ToolChoice = Messages1::BetaToolChoice.Create(
                    new Messages1::BetaToolChoiceAuto()
                    {
                        Type = BetaToolChoiceAutoProperties::Type.Auto,
                        DisableParallelToolUse = true,
                    }
                ),
                Tools =
                [
                    MessageCountTokensParamsProperties::Tool.Create(
                        new Messages1::BetaTool()
                        {
                            InputSchema = new BetaToolProperties::InputSchema()
                            {
                                Type = InputSchemaProperties::Type.Object,
                                Properties1 = Json::JsonSerializer.Deserialize<Json::JsonElement>(
                                    "{\"location\":{\"description\":\"The city and state, e.g. San Francisco, CA\",\"type\":\"string\"},\"unit\":{\"description\":\"Unit for the output - one of (celsius, fahrenheit)\",\"type\":\"string\"}}"
                                ),
                                Required = ["location"],
                            },
                            Name = "name",
                            CacheControl = new Messages1::BetaCacheControlEphemeral()
                            {
                                Type = BetaCacheControlEphemeralProperties::Type.Ephemeral,
                                TTL = BetaCacheControlEphemeralProperties::TTL.TTL5m,
                            },
                            Description = "Get the current weather in a given location",
                            Type = BetaToolProperties::Type.Custom,
                        }
                    ),
                ],
                Betas = [Beta::AnthropicBeta.MessageBatches2024_09_24],
            }
        );
        betaMessageTokensCount.Validate();
    }
}
