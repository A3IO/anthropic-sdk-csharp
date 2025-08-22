using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using BetaContentBlockVariants = Anthropic.Models.Beta.Messages.BetaContentBlockVariants;

namespace Anthropic.Models.Beta.Messages;

/// <summary>
/// Response model for a file uploaded to the container.
/// </summary>
[JsonConverter(typeof(BetaContentBlockConverter))]
public abstract record class BetaContentBlock
{
    internal BetaContentBlock() { }

    public static implicit operator BetaContentBlock(BetaTextBlock value) =>
        new BetaContentBlockVariants::BetaTextBlock(value);

    public static implicit operator BetaContentBlock(BetaThinkingBlock value) =>
        new BetaContentBlockVariants::BetaThinkingBlock(value);

    public static implicit operator BetaContentBlock(BetaRedactedThinkingBlock value) =>
        new BetaContentBlockVariants::BetaRedactedThinkingBlock(value);

    public static implicit operator BetaContentBlock(BetaToolUseBlock value) =>
        new BetaContentBlockVariants::BetaToolUseBlock(value);

    public static implicit operator BetaContentBlock(BetaServerToolUseBlock value) =>
        new BetaContentBlockVariants::BetaServerToolUseBlock(value);

    public static implicit operator BetaContentBlock(BetaWebSearchToolResultBlock value) =>
        new BetaContentBlockVariants::BetaWebSearchToolResultBlock(value);

    public static implicit operator BetaContentBlock(BetaCodeExecutionToolResultBlock value) =>
        new BetaContentBlockVariants::BetaCodeExecutionToolResultBlock(value);

    public static implicit operator BetaContentBlock(BetaMCPToolUseBlock value) =>
        new BetaContentBlockVariants::BetaMCPToolUseBlock(value);

    public static implicit operator BetaContentBlock(BetaMCPToolResultBlock value) =>
        new BetaContentBlockVariants::BetaMCPToolResultBlock(value);

    public static implicit operator BetaContentBlock(BetaContainerUploadBlock value) =>
        new BetaContentBlockVariants::BetaContainerUploadBlock(value);

    public bool TryPickBetaTextBlock([NotNullWhen(true)] out BetaTextBlock? value)
    {
        value = (this as BetaContentBlockVariants::BetaTextBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaThinkingBlock([NotNullWhen(true)] out BetaThinkingBlock? value)
    {
        value = (this as BetaContentBlockVariants::BetaThinkingBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaRedactedThinkingBlock(
        [NotNullWhen(true)] out BetaRedactedThinkingBlock? value
    )
    {
        value = (this as BetaContentBlockVariants::BetaRedactedThinkingBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaToolUseBlock([NotNullWhen(true)] out BetaToolUseBlock? value)
    {
        value = (this as BetaContentBlockVariants::BetaToolUseBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaServerToolUseBlock([NotNullWhen(true)] out BetaServerToolUseBlock? value)
    {
        value = (this as BetaContentBlockVariants::BetaServerToolUseBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaWebSearchToolResultBlock(
        [NotNullWhen(true)] out BetaWebSearchToolResultBlock? value
    )
    {
        value = (this as BetaContentBlockVariants::BetaWebSearchToolResultBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaCodeExecutionToolResultBlock(
        [NotNullWhen(true)] out BetaCodeExecutionToolResultBlock? value
    )
    {
        value = (this as BetaContentBlockVariants::BetaCodeExecutionToolResultBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaMCPToolUseBlock([NotNullWhen(true)] out BetaMCPToolUseBlock? value)
    {
        value = (this as BetaContentBlockVariants::BetaMCPToolUseBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaMCPToolResultBlock([NotNullWhen(true)] out BetaMCPToolResultBlock? value)
    {
        value = (this as BetaContentBlockVariants::BetaMCPToolResultBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaContainerUploadBlock(
        [NotNullWhen(true)] out BetaContainerUploadBlock? value
    )
    {
        value = (this as BetaContentBlockVariants::BetaContainerUploadBlock)?.Value;
        return value != null;
    }

    public void Switch(
        Action<BetaContentBlockVariants::BetaTextBlock> betaTextBlock,
        Action<BetaContentBlockVariants::BetaThinkingBlock> betaThinkingBlock,
        Action<BetaContentBlockVariants::BetaRedactedThinkingBlock> betaRedactedThinkingBlock,
        Action<BetaContentBlockVariants::BetaToolUseBlock> betaToolUseBlock,
        Action<BetaContentBlockVariants::BetaServerToolUseBlock> betaServerToolUseBlock,
        Action<BetaContentBlockVariants::BetaWebSearchToolResultBlock> betaWebSearchToolResultBlock,
        Action<BetaContentBlockVariants::BetaCodeExecutionToolResultBlock> betaCodeExecutionToolResultBlock,
        Action<BetaContentBlockVariants::BetaMCPToolUseBlock> betaMCPToolUseBlock,
        Action<BetaContentBlockVariants::BetaMCPToolResultBlock> betaMCPToolResultBlock,
        Action<BetaContentBlockVariants::BetaContainerUploadBlock> betaContainerUploadBlock
    )
    {
        switch (this)
        {
            case BetaContentBlockVariants::BetaTextBlock inner:
                betaTextBlock(inner);
                break;
            case BetaContentBlockVariants::BetaThinkingBlock inner:
                betaThinkingBlock(inner);
                break;
            case BetaContentBlockVariants::BetaRedactedThinkingBlock inner:
                betaRedactedThinkingBlock(inner);
                break;
            case BetaContentBlockVariants::BetaToolUseBlock inner:
                betaToolUseBlock(inner);
                break;
            case BetaContentBlockVariants::BetaServerToolUseBlock inner:
                betaServerToolUseBlock(inner);
                break;
            case BetaContentBlockVariants::BetaWebSearchToolResultBlock inner:
                betaWebSearchToolResultBlock(inner);
                break;
            case BetaContentBlockVariants::BetaCodeExecutionToolResultBlock inner:
                betaCodeExecutionToolResultBlock(inner);
                break;
            case BetaContentBlockVariants::BetaMCPToolUseBlock inner:
                betaMCPToolUseBlock(inner);
                break;
            case BetaContentBlockVariants::BetaMCPToolResultBlock inner:
                betaMCPToolResultBlock(inner);
                break;
            case BetaContentBlockVariants::BetaContainerUploadBlock inner:
                betaContainerUploadBlock(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<BetaContentBlockVariants::BetaTextBlock, T> betaTextBlock,
        Func<BetaContentBlockVariants::BetaThinkingBlock, T> betaThinkingBlock,
        Func<BetaContentBlockVariants::BetaRedactedThinkingBlock, T> betaRedactedThinkingBlock,
        Func<BetaContentBlockVariants::BetaToolUseBlock, T> betaToolUseBlock,
        Func<BetaContentBlockVariants::BetaServerToolUseBlock, T> betaServerToolUseBlock,
        Func<
            BetaContentBlockVariants::BetaWebSearchToolResultBlock,
            T
        > betaWebSearchToolResultBlock,
        Func<
            BetaContentBlockVariants::BetaCodeExecutionToolResultBlock,
            T
        > betaCodeExecutionToolResultBlock,
        Func<BetaContentBlockVariants::BetaMCPToolUseBlock, T> betaMCPToolUseBlock,
        Func<BetaContentBlockVariants::BetaMCPToolResultBlock, T> betaMCPToolResultBlock,
        Func<BetaContentBlockVariants::BetaContainerUploadBlock, T> betaContainerUploadBlock
    )
    {
        return this switch
        {
            BetaContentBlockVariants::BetaTextBlock inner => betaTextBlock(inner),
            BetaContentBlockVariants::BetaThinkingBlock inner => betaThinkingBlock(inner),
            BetaContentBlockVariants::BetaRedactedThinkingBlock inner => betaRedactedThinkingBlock(
                inner
            ),
            BetaContentBlockVariants::BetaToolUseBlock inner => betaToolUseBlock(inner),
            BetaContentBlockVariants::BetaServerToolUseBlock inner => betaServerToolUseBlock(inner),
            BetaContentBlockVariants::BetaWebSearchToolResultBlock inner =>
                betaWebSearchToolResultBlock(inner),
            BetaContentBlockVariants::BetaCodeExecutionToolResultBlock inner =>
                betaCodeExecutionToolResultBlock(inner),
            BetaContentBlockVariants::BetaMCPToolUseBlock inner => betaMCPToolUseBlock(inner),
            BetaContentBlockVariants::BetaMCPToolResultBlock inner => betaMCPToolResultBlock(inner),
            BetaContentBlockVariants::BetaContainerUploadBlock inner => betaContainerUploadBlock(
                inner
            ),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class BetaContentBlockConverter : JsonConverter<BetaContentBlock>
{
    public override BetaContentBlock? Read(
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
                    var deserialized = JsonSerializer.Deserialize<BetaTextBlock>(json, options);
                    if (deserialized != null)
                    {
                        return new BetaContentBlockVariants::BetaTextBlock(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<BetaThinkingBlock>(json, options);
                    if (deserialized != null)
                    {
                        return new BetaContentBlockVariants::BetaThinkingBlock(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<BetaRedactedThinkingBlock>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockVariants::BetaRedactedThinkingBlock(
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
                    var deserialized = JsonSerializer.Deserialize<BetaToolUseBlock>(json, options);
                    if (deserialized != null)
                    {
                        return new BetaContentBlockVariants::BetaToolUseBlock(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<BetaServerToolUseBlock>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockVariants::BetaServerToolUseBlock(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<BetaWebSearchToolResultBlock>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockVariants::BetaWebSearchToolResultBlock(
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
                    var deserialized = JsonSerializer.Deserialize<BetaCodeExecutionToolResultBlock>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockVariants::BetaCodeExecutionToolResultBlock(
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
                    var deserialized = JsonSerializer.Deserialize<BetaMCPToolUseBlock>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockVariants::BetaMCPToolUseBlock(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<BetaMCPToolResultBlock>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockVariants::BetaMCPToolResultBlock(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<BetaContainerUploadBlock>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaContentBlockVariants::BetaContainerUploadBlock(deserialized);
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
        BetaContentBlock value,
        JsonSerializerOptions options
    )
    {
        object variant = value switch
        {
            BetaContentBlockVariants::BetaTextBlock(var betaTextBlock) => betaTextBlock,
            BetaContentBlockVariants::BetaThinkingBlock(var betaThinkingBlock) => betaThinkingBlock,
            BetaContentBlockVariants::BetaRedactedThinkingBlock(var betaRedactedThinkingBlock) =>
                betaRedactedThinkingBlock,
            BetaContentBlockVariants::BetaToolUseBlock(var betaToolUseBlock) => betaToolUseBlock,
            BetaContentBlockVariants::BetaServerToolUseBlock(var betaServerToolUseBlock) =>
                betaServerToolUseBlock,
            BetaContentBlockVariants::BetaWebSearchToolResultBlock(
                var betaWebSearchToolResultBlock
            ) => betaWebSearchToolResultBlock,
            BetaContentBlockVariants::BetaCodeExecutionToolResultBlock(
                var betaCodeExecutionToolResultBlock
            ) => betaCodeExecutionToolResultBlock,
            BetaContentBlockVariants::BetaMCPToolUseBlock(var betaMCPToolUseBlock) =>
                betaMCPToolUseBlock,
            BetaContentBlockVariants::BetaMCPToolResultBlock(var betaMCPToolResultBlock) =>
                betaMCPToolResultBlock,
            BetaContentBlockVariants::BetaContainerUploadBlock(var betaContainerUploadBlock) =>
                betaContainerUploadBlock,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
