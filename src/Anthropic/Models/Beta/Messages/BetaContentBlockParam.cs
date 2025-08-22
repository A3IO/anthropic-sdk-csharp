using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using BetaContentBlockParamVariants = Anthropic.Models.Beta.Messages.BetaContentBlockParamVariants;

namespace Anthropic.Models.Beta.Messages;

/// <summary>
/// Regular text content.
/// </summary>
[JsonConverter(typeof(BetaContentBlockParamConverter))]
public abstract record class BetaContentBlockParam
{
    internal BetaContentBlockParam() { }

    public static implicit operator BetaContentBlockParam(BetaTextBlockParam value) =>
        new BetaContentBlockParamVariants::BetaTextBlockParam(value);

    public static implicit operator BetaContentBlockParam(BetaImageBlockParam value) =>
        new BetaContentBlockParamVariants::BetaImageBlockParam(value);

    public static implicit operator BetaContentBlockParam(BetaRequestDocumentBlock value) =>
        new BetaContentBlockParamVariants::BetaRequestDocumentBlock(value);

    public static implicit operator BetaContentBlockParam(BetaSearchResultBlockParam value) =>
        new BetaContentBlockParamVariants::BetaSearchResultBlockParam(value);

    public static implicit operator BetaContentBlockParam(BetaThinkingBlockParam value) =>
        new BetaContentBlockParamVariants::BetaThinkingBlockParam(value);

    public static implicit operator BetaContentBlockParam(BetaRedactedThinkingBlockParam value) =>
        new BetaContentBlockParamVariants::BetaRedactedThinkingBlockParam(value);

    public static implicit operator BetaContentBlockParam(BetaToolUseBlockParam value) =>
        new BetaContentBlockParamVariants::BetaToolUseBlockParam(value);

    public static implicit operator BetaContentBlockParam(BetaToolResultBlockParam value) =>
        new BetaContentBlockParamVariants::BetaToolResultBlockParam(value);

    public static implicit operator BetaContentBlockParam(BetaServerToolUseBlockParam value) =>
        new BetaContentBlockParamVariants::BetaServerToolUseBlockParam(value);

    public static implicit operator BetaContentBlockParam(
        BetaWebSearchToolResultBlockParam value
    ) => new BetaContentBlockParamVariants::BetaWebSearchToolResultBlockParam(value);

    public static implicit operator BetaContentBlockParam(
        BetaCodeExecutionToolResultBlockParam value
    ) => new BetaContentBlockParamVariants::BetaCodeExecutionToolResultBlockParam(value);

    public static implicit operator BetaContentBlockParam(BetaMCPToolUseBlockParam value) =>
        new BetaContentBlockParamVariants::BetaMCPToolUseBlockParam(value);

    public static implicit operator BetaContentBlockParam(
        BetaRequestMCPToolResultBlockParam value
    ) => new BetaContentBlockParamVariants::BetaRequestMCPToolResultBlockParam(value);

    public static implicit operator BetaContentBlockParam(BetaContainerUploadBlockParam value) =>
        new BetaContentBlockParamVariants::BetaContainerUploadBlockParam(value);

    public bool TryPickBetaTextBlockParam([NotNullWhen(true)] out BetaTextBlockParam? value)
    {
        value = (this as BetaContentBlockParamVariants::BetaTextBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickBetaImageBlockParam([NotNullWhen(true)] out BetaImageBlockParam? value)
    {
        value = (this as BetaContentBlockParamVariants::BetaImageBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickBetaRequestDocumentBlock(
        [NotNullWhen(true)] out BetaRequestDocumentBlock? value
    )
    {
        value = (this as BetaContentBlockParamVariants::BetaRequestDocumentBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaSearchResultBlockParam(
        [NotNullWhen(true)] out BetaSearchResultBlockParam? value
    )
    {
        value = (this as BetaContentBlockParamVariants::BetaSearchResultBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickBetaThinkingBlockParam([NotNullWhen(true)] out BetaThinkingBlockParam? value)
    {
        value = (this as BetaContentBlockParamVariants::BetaThinkingBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickBetaRedactedThinkingBlockParam(
        [NotNullWhen(true)] out BetaRedactedThinkingBlockParam? value
    )
    {
        value = (this as BetaContentBlockParamVariants::BetaRedactedThinkingBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickBetaToolUseBlockParam([NotNullWhen(true)] out BetaToolUseBlockParam? value)
    {
        value = (this as BetaContentBlockParamVariants::BetaToolUseBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickBetaToolResultBlockParam(
        [NotNullWhen(true)] out BetaToolResultBlockParam? value
    )
    {
        value = (this as BetaContentBlockParamVariants::BetaToolResultBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickBetaServerToolUseBlockParam(
        [NotNullWhen(true)] out BetaServerToolUseBlockParam? value
    )
    {
        value = (this as BetaContentBlockParamVariants::BetaServerToolUseBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickBetaWebSearchToolResultBlockParam(
        [NotNullWhen(true)] out BetaWebSearchToolResultBlockParam? value
    )
    {
        value = (this as BetaContentBlockParamVariants::BetaWebSearchToolResultBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickBetaCodeExecutionToolResultBlockParam(
        [NotNullWhen(true)] out BetaCodeExecutionToolResultBlockParam? value
    )
    {
        value = (
            this as BetaContentBlockParamVariants::BetaCodeExecutionToolResultBlockParam
        )?.Value;
        return value != null;
    }

    public bool TryPickBetaMCPToolUseBlockParam(
        [NotNullWhen(true)] out BetaMCPToolUseBlockParam? value
    )
    {
        value = (this as BetaContentBlockParamVariants::BetaMCPToolUseBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickBetaRequestMCPToolResultBlockParam(
        [NotNullWhen(true)] out BetaRequestMCPToolResultBlockParam? value
    )
    {
        value = (this as BetaContentBlockParamVariants::BetaRequestMCPToolResultBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickBetaContainerUploadBlockParam(
        [NotNullWhen(true)] out BetaContainerUploadBlockParam? value
    )
    {
        value = (this as BetaContentBlockParamVariants::BetaContainerUploadBlockParam)?.Value;
        return value != null;
    }

    public void Switch(
        Action<BetaContentBlockParamVariants::BetaTextBlockParam> betaTextBlockParam,
        Action<BetaContentBlockParamVariants::BetaImageBlockParam> betaImageBlockParam,
        Action<BetaContentBlockParamVariants::BetaRequestDocumentBlock> betaRequestDocumentBlock,
        Action<BetaContentBlockParamVariants::BetaSearchResultBlockParam> betaSearchResultBlockParam,
        Action<BetaContentBlockParamVariants::BetaThinkingBlockParam> betaThinkingBlockParam,
        Action<BetaContentBlockParamVariants::BetaRedactedThinkingBlockParam> betaRedactedThinkingBlockParam,
        Action<BetaContentBlockParamVariants::BetaToolUseBlockParam> betaToolUseBlockParam,
        Action<BetaContentBlockParamVariants::BetaToolResultBlockParam> betaToolResultBlockParam,
        Action<BetaContentBlockParamVariants::BetaServerToolUseBlockParam> betaServerToolUseBlockParam,
        Action<BetaContentBlockParamVariants::BetaWebSearchToolResultBlockParam> betaWebSearchToolResultBlockParam,
        Action<BetaContentBlockParamVariants::BetaCodeExecutionToolResultBlockParam> betaCodeExecutionToolResultBlockParam,
        Action<BetaContentBlockParamVariants::BetaMCPToolUseBlockParam> betaMCPToolUseBlockParam,
        Action<BetaContentBlockParamVariants::BetaRequestMCPToolResultBlockParam> betaRequestMCPToolResultBlockParam,
        Action<BetaContentBlockParamVariants::BetaContainerUploadBlockParam> betaContainerUploadBlockParam
    )
    {
        switch (this)
        {
            case BetaContentBlockParamVariants::BetaTextBlockParam inner:
                betaTextBlockParam(inner);
                break;
            case BetaContentBlockParamVariants::BetaImageBlockParam inner:
                betaImageBlockParam(inner);
                break;
            case BetaContentBlockParamVariants::BetaRequestDocumentBlock inner:
                betaRequestDocumentBlock(inner);
                break;
            case BetaContentBlockParamVariants::BetaSearchResultBlockParam inner:
                betaSearchResultBlockParam(inner);
                break;
            case BetaContentBlockParamVariants::BetaThinkingBlockParam inner:
                betaThinkingBlockParam(inner);
                break;
            case BetaContentBlockParamVariants::BetaRedactedThinkingBlockParam inner:
                betaRedactedThinkingBlockParam(inner);
                break;
            case BetaContentBlockParamVariants::BetaToolUseBlockParam inner:
                betaToolUseBlockParam(inner);
                break;
            case BetaContentBlockParamVariants::BetaToolResultBlockParam inner:
                betaToolResultBlockParam(inner);
                break;
            case BetaContentBlockParamVariants::BetaServerToolUseBlockParam inner:
                betaServerToolUseBlockParam(inner);
                break;
            case BetaContentBlockParamVariants::BetaWebSearchToolResultBlockParam inner:
                betaWebSearchToolResultBlockParam(inner);
                break;
            case BetaContentBlockParamVariants::BetaCodeExecutionToolResultBlockParam inner:
                betaCodeExecutionToolResultBlockParam(inner);
                break;
            case BetaContentBlockParamVariants::BetaMCPToolUseBlockParam inner:
                betaMCPToolUseBlockParam(inner);
                break;
            case BetaContentBlockParamVariants::BetaRequestMCPToolResultBlockParam inner:
                betaRequestMCPToolResultBlockParam(inner);
                break;
            case BetaContentBlockParamVariants::BetaContainerUploadBlockParam inner:
                betaContainerUploadBlockParam(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<BetaContentBlockParamVariants::BetaTextBlockParam, T> betaTextBlockParam,
        Func<BetaContentBlockParamVariants::BetaImageBlockParam, T> betaImageBlockParam,
        Func<BetaContentBlockParamVariants::BetaRequestDocumentBlock, T> betaRequestDocumentBlock,
        Func<
            BetaContentBlockParamVariants::BetaSearchResultBlockParam,
            T
        > betaSearchResultBlockParam,
        Func<BetaContentBlockParamVariants::BetaThinkingBlockParam, T> betaThinkingBlockParam,
        Func<
            BetaContentBlockParamVariants::BetaRedactedThinkingBlockParam,
            T
        > betaRedactedThinkingBlockParam,
        Func<BetaContentBlockParamVariants::BetaToolUseBlockParam, T> betaToolUseBlockParam,
        Func<BetaContentBlockParamVariants::BetaToolResultBlockParam, T> betaToolResultBlockParam,
        Func<
            BetaContentBlockParamVariants::BetaServerToolUseBlockParam,
            T
        > betaServerToolUseBlockParam,
        Func<
            BetaContentBlockParamVariants::BetaWebSearchToolResultBlockParam,
            T
        > betaWebSearchToolResultBlockParam,
        Func<
            BetaContentBlockParamVariants::BetaCodeExecutionToolResultBlockParam,
            T
        > betaCodeExecutionToolResultBlockParam,
        Func<BetaContentBlockParamVariants::BetaMCPToolUseBlockParam, T> betaMCPToolUseBlockParam,
        Func<
            BetaContentBlockParamVariants::BetaRequestMCPToolResultBlockParam,
            T
        > betaRequestMCPToolResultBlockParam,
        Func<
            BetaContentBlockParamVariants::BetaContainerUploadBlockParam,
            T
        > betaContainerUploadBlockParam
    )
    {
        return this switch
        {
            BetaContentBlockParamVariants::BetaTextBlockParam inner => betaTextBlockParam(inner),
            BetaContentBlockParamVariants::BetaImageBlockParam inner => betaImageBlockParam(inner),
            BetaContentBlockParamVariants::BetaRequestDocumentBlock inner =>
                betaRequestDocumentBlock(inner),
            BetaContentBlockParamVariants::BetaSearchResultBlockParam inner =>
                betaSearchResultBlockParam(inner),
            BetaContentBlockParamVariants::BetaThinkingBlockParam inner => betaThinkingBlockParam(
                inner
            ),
            BetaContentBlockParamVariants::BetaRedactedThinkingBlockParam inner =>
                betaRedactedThinkingBlockParam(inner),
            BetaContentBlockParamVariants::BetaToolUseBlockParam inner => betaToolUseBlockParam(
                inner
            ),
            BetaContentBlockParamVariants::BetaToolResultBlockParam inner =>
                betaToolResultBlockParam(inner),
            BetaContentBlockParamVariants::BetaServerToolUseBlockParam inner =>
                betaServerToolUseBlockParam(inner),
            BetaContentBlockParamVariants::BetaWebSearchToolResultBlockParam inner =>
                betaWebSearchToolResultBlockParam(inner),
            BetaContentBlockParamVariants::BetaCodeExecutionToolResultBlockParam inner =>
                betaCodeExecutionToolResultBlockParam(inner),
            BetaContentBlockParamVariants::BetaMCPToolUseBlockParam inner =>
                betaMCPToolUseBlockParam(inner),
            BetaContentBlockParamVariants::BetaRequestMCPToolResultBlockParam inner =>
                betaRequestMCPToolResultBlockParam(inner),
            BetaContentBlockParamVariants::BetaContainerUploadBlockParam inner =>
                betaContainerUploadBlockParam(inner),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class BetaContentBlockParamConverter : JsonConverter<BetaContentBlockParam>
{
    public override BetaContentBlockParam? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        var json = JsonSerializer.Deserialize<JsonElement>(ref reader, options);
        string? type;
        try
        {
            type = json.GetProperty("type").GetString();
        }
        catch
        {
            type = null;
        }

        switch (type)
        {
            case "text":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaTextBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockParamVariants::BetaTextBlockParam(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "image":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaImageBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockParamVariants::BetaImageBlockParam(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "document":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaRequestDocumentBlock>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockParamVariants::BetaRequestDocumentBlock(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "search_result":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaSearchResultBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockParamVariants::BetaSearchResultBlockParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "thinking":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaThinkingBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockParamVariants::BetaThinkingBlockParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "redacted_thinking":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaRedactedThinkingBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockParamVariants::BetaRedactedThinkingBlockParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "tool_use":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaToolUseBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockParamVariants::BetaToolUseBlockParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "tool_result":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaToolResultBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockParamVariants::BetaToolResultBlockParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "server_tool_use":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaServerToolUseBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockParamVariants::BetaServerToolUseBlockParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "web_search_tool_result":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized =
                        JsonSerializer.Deserialize<BetaWebSearchToolResultBlockParam>(
                            json,
                            options
                        );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockParamVariants::BetaWebSearchToolResultBlockParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "code_execution_tool_result":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized =
                        JsonSerializer.Deserialize<BetaCodeExecutionToolResultBlockParam>(
                            json,
                            options
                        );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockParamVariants::BetaCodeExecutionToolResultBlockParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "mcp_tool_use":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaMCPToolUseBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockParamVariants::BetaMCPToolUseBlockParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "mcp_tool_result":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized =
                        JsonSerializer.Deserialize<BetaRequestMCPToolResultBlockParam>(
                            json,
                            options
                        );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockParamVariants::BetaRequestMCPToolResultBlockParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "container_upload":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaContainerUploadBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockParamVariants::BetaContainerUploadBlockParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            default:
            {
                throw new Exception();
            }
        }
    }

    public override void Write(
        Utf8JsonWriter writer,
        BetaContentBlockParam value,
        JsonSerializerOptions options
    )
    {
        object variant = value switch
        {
            BetaContentBlockParamVariants::BetaTextBlockParam(var betaTextBlockParam) =>
                betaTextBlockParam,
            BetaContentBlockParamVariants::BetaImageBlockParam(var betaImageBlockParam) =>
                betaImageBlockParam,
            BetaContentBlockParamVariants::BetaRequestDocumentBlock(var betaRequestDocumentBlock) =>
                betaRequestDocumentBlock,
            BetaContentBlockParamVariants::BetaSearchResultBlockParam(
                var betaSearchResultBlockParam
            ) => betaSearchResultBlockParam,
            BetaContentBlockParamVariants::BetaThinkingBlockParam(var betaThinkingBlockParam) =>
                betaThinkingBlockParam,
            BetaContentBlockParamVariants::BetaRedactedThinkingBlockParam(
                var betaRedactedThinkingBlockParam
            ) => betaRedactedThinkingBlockParam,
            BetaContentBlockParamVariants::BetaToolUseBlockParam(var betaToolUseBlockParam) =>
                betaToolUseBlockParam,
            BetaContentBlockParamVariants::BetaToolResultBlockParam(var betaToolResultBlockParam) =>
                betaToolResultBlockParam,
            BetaContentBlockParamVariants::BetaServerToolUseBlockParam(
                var betaServerToolUseBlockParam
            ) => betaServerToolUseBlockParam,
            BetaContentBlockParamVariants::BetaWebSearchToolResultBlockParam(
                var betaWebSearchToolResultBlockParam
            ) => betaWebSearchToolResultBlockParam,
            BetaContentBlockParamVariants::BetaCodeExecutionToolResultBlockParam(
                var betaCodeExecutionToolResultBlockParam
            ) => betaCodeExecutionToolResultBlockParam,
            BetaContentBlockParamVariants::BetaMCPToolUseBlockParam(var betaMCPToolUseBlockParam) =>
                betaMCPToolUseBlockParam,
            BetaContentBlockParamVariants::BetaRequestMCPToolResultBlockParam(
                var betaRequestMCPToolResultBlockParam
            ) => betaRequestMCPToolResultBlockParam,
            BetaContentBlockParamVariants::BetaContainerUploadBlockParam(
                var betaContainerUploadBlockParam
            ) => betaContainerUploadBlockParam,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
