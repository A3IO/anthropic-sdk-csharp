using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ContentBlockVariants = Anthropic.Models.Beta.Messages.BetaRawContentBlockStartEventProperties.ContentBlockVariants;

namespace Anthropic.Models.Beta.Messages.BetaRawContentBlockStartEventProperties;

/// <summary>
/// Response model for a file uploaded to the container.
/// </summary>
[JsonConverter(typeof(ContentBlockConverter))]
public abstract record class ContentBlock
{
    internal ContentBlock() { }

    public static implicit operator ContentBlock(BetaTextBlock value) =>
        new ContentBlockVariants::BetaTextBlock(value);

    public static implicit operator ContentBlock(BetaThinkingBlock value) =>
        new ContentBlockVariants::BetaThinkingBlock(value);

    public static implicit operator ContentBlock(BetaRedactedThinkingBlock value) =>
        new ContentBlockVariants::BetaRedactedThinkingBlock(value);

    public static implicit operator ContentBlock(BetaToolUseBlock value) =>
        new ContentBlockVariants::BetaToolUseBlock(value);

    public static implicit operator ContentBlock(BetaServerToolUseBlock value) =>
        new ContentBlockVariants::BetaServerToolUseBlock(value);

    public static implicit operator ContentBlock(BetaWebSearchToolResultBlock value) =>
        new ContentBlockVariants::BetaWebSearchToolResultBlock(value);

    public static implicit operator ContentBlock(BetaCodeExecutionToolResultBlock value) =>
        new ContentBlockVariants::BetaCodeExecutionToolResultBlock(value);

    public static implicit operator ContentBlock(BetaMCPToolUseBlock value) =>
        new ContentBlockVariants::BetaMCPToolUseBlock(value);

    public static implicit operator ContentBlock(BetaMCPToolResultBlock value) =>
        new ContentBlockVariants::BetaMCPToolResultBlock(value);

    public static implicit operator ContentBlock(BetaContainerUploadBlock value) =>
        new ContentBlockVariants::BetaContainerUploadBlock(value);

    public bool TryPickBetaTextBlock([NotNullWhen(true)] out BetaTextBlock? value)
    {
        value = (this as ContentBlockVariants::BetaTextBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaThinkingBlock([NotNullWhen(true)] out BetaThinkingBlock? value)
    {
        value = (this as ContentBlockVariants::BetaThinkingBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaRedactedThinkingBlock(
        [NotNullWhen(true)] out BetaRedactedThinkingBlock? value
    )
    {
        value = (this as ContentBlockVariants::BetaRedactedThinkingBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaToolUseBlock([NotNullWhen(true)] out BetaToolUseBlock? value)
    {
        value = (this as ContentBlockVariants::BetaToolUseBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaServerToolUseBlock([NotNullWhen(true)] out BetaServerToolUseBlock? value)
    {
        value = (this as ContentBlockVariants::BetaServerToolUseBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaWebSearchToolResultBlock(
        [NotNullWhen(true)] out BetaWebSearchToolResultBlock? value
    )
    {
        value = (this as ContentBlockVariants::BetaWebSearchToolResultBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaCodeExecutionToolResultBlock(
        [NotNullWhen(true)] out BetaCodeExecutionToolResultBlock? value
    )
    {
        value = (this as ContentBlockVariants::BetaCodeExecutionToolResultBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaMCPToolUseBlock([NotNullWhen(true)] out BetaMCPToolUseBlock? value)
    {
        value = (this as ContentBlockVariants::BetaMCPToolUseBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaMCPToolResultBlock([NotNullWhen(true)] out BetaMCPToolResultBlock? value)
    {
        value = (this as ContentBlockVariants::BetaMCPToolResultBlock)?.Value;
        return value != null;
    }

    public bool TryPickBetaContainerUploadBlock(
        [NotNullWhen(true)] out BetaContainerUploadBlock? value
    )
    {
        value = (this as ContentBlockVariants::BetaContainerUploadBlock)?.Value;
        return value != null;
    }

    public void Switch(
        Action<ContentBlockVariants::BetaTextBlock> betaTextBlock,
        Action<ContentBlockVariants::BetaThinkingBlock> betaThinkingBlock,
        Action<ContentBlockVariants::BetaRedactedThinkingBlock> betaRedactedThinkingBlock,
        Action<ContentBlockVariants::BetaToolUseBlock> betaToolUseBlock,
        Action<ContentBlockVariants::BetaServerToolUseBlock> betaServerToolUseBlock,
        Action<ContentBlockVariants::BetaWebSearchToolResultBlock> betaWebSearchToolResultBlock,
        Action<ContentBlockVariants::BetaCodeExecutionToolResultBlock> betaCodeExecutionToolResultBlock,
        Action<ContentBlockVariants::BetaMCPToolUseBlock> betaMCPToolUseBlock,
        Action<ContentBlockVariants::BetaMCPToolResultBlock> betaMCPToolResultBlock,
        Action<ContentBlockVariants::BetaContainerUploadBlock> betaContainerUploadBlock
    )
    {
        switch (this)
        {
            case ContentBlockVariants::BetaTextBlock inner:
                betaTextBlock(inner);
                break;
            case ContentBlockVariants::BetaThinkingBlock inner:
                betaThinkingBlock(inner);
                break;
            case ContentBlockVariants::BetaRedactedThinkingBlock inner:
                betaRedactedThinkingBlock(inner);
                break;
            case ContentBlockVariants::BetaToolUseBlock inner:
                betaToolUseBlock(inner);
                break;
            case ContentBlockVariants::BetaServerToolUseBlock inner:
                betaServerToolUseBlock(inner);
                break;
            case ContentBlockVariants::BetaWebSearchToolResultBlock inner:
                betaWebSearchToolResultBlock(inner);
                break;
            case ContentBlockVariants::BetaCodeExecutionToolResultBlock inner:
                betaCodeExecutionToolResultBlock(inner);
                break;
            case ContentBlockVariants::BetaMCPToolUseBlock inner:
                betaMCPToolUseBlock(inner);
                break;
            case ContentBlockVariants::BetaMCPToolResultBlock inner:
                betaMCPToolResultBlock(inner);
                break;
            case ContentBlockVariants::BetaContainerUploadBlock inner:
                betaContainerUploadBlock(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<ContentBlockVariants::BetaTextBlock, T> betaTextBlock,
        Func<ContentBlockVariants::BetaThinkingBlock, T> betaThinkingBlock,
        Func<ContentBlockVariants::BetaRedactedThinkingBlock, T> betaRedactedThinkingBlock,
        Func<ContentBlockVariants::BetaToolUseBlock, T> betaToolUseBlock,
        Func<ContentBlockVariants::BetaServerToolUseBlock, T> betaServerToolUseBlock,
        Func<ContentBlockVariants::BetaWebSearchToolResultBlock, T> betaWebSearchToolResultBlock,
        Func<
            ContentBlockVariants::BetaCodeExecutionToolResultBlock,
            T
        > betaCodeExecutionToolResultBlock,
        Func<ContentBlockVariants::BetaMCPToolUseBlock, T> betaMCPToolUseBlock,
        Func<ContentBlockVariants::BetaMCPToolResultBlock, T> betaMCPToolResultBlock,
        Func<ContentBlockVariants::BetaContainerUploadBlock, T> betaContainerUploadBlock
    )
    {
        return this switch
        {
            ContentBlockVariants::BetaTextBlock inner => betaTextBlock(inner),
            ContentBlockVariants::BetaThinkingBlock inner => betaThinkingBlock(inner),
            ContentBlockVariants::BetaRedactedThinkingBlock inner => betaRedactedThinkingBlock(
                inner
            ),
            ContentBlockVariants::BetaToolUseBlock inner => betaToolUseBlock(inner),
            ContentBlockVariants::BetaServerToolUseBlock inner => betaServerToolUseBlock(inner),
            ContentBlockVariants::BetaWebSearchToolResultBlock inner =>
                betaWebSearchToolResultBlock(inner),
            ContentBlockVariants::BetaCodeExecutionToolResultBlock inner =>
                betaCodeExecutionToolResultBlock(inner),
            ContentBlockVariants::BetaMCPToolUseBlock inner => betaMCPToolUseBlock(inner),
            ContentBlockVariants::BetaMCPToolResultBlock inner => betaMCPToolResultBlock(inner),
            ContentBlockVariants::BetaContainerUploadBlock inner => betaContainerUploadBlock(inner),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class ContentBlockConverter : JsonConverter<ContentBlock>
{
    public override ContentBlock? Read(
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
                        return new ContentBlockVariants::BetaTextBlock(deserialized);
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
                        return new ContentBlockVariants::BetaThinkingBlock(deserialized);
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
                        return new ContentBlockVariants::BetaRedactedThinkingBlock(deserialized);
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
                        return new ContentBlockVariants::BetaToolUseBlock(deserialized);
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
                        return new ContentBlockVariants::BetaServerToolUseBlock(deserialized);
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
                        return new ContentBlockVariants::BetaWebSearchToolResultBlock(deserialized);
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
                        return new ContentBlockVariants::BetaCodeExecutionToolResultBlock(
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
                        return new ContentBlockVariants::BetaMCPToolUseBlock(deserialized);
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
                        return new ContentBlockVariants::BetaMCPToolResultBlock(deserialized);
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
                        return new ContentBlockVariants::BetaContainerUploadBlock(deserialized);
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
        ContentBlock value,
        JsonSerializerOptions options
    )
    {
        object variant = value switch
        {
            ContentBlockVariants::BetaTextBlock(var betaTextBlock) => betaTextBlock,
            ContentBlockVariants::BetaThinkingBlock(var betaThinkingBlock) => betaThinkingBlock,
            ContentBlockVariants::BetaRedactedThinkingBlock(var betaRedactedThinkingBlock) =>
                betaRedactedThinkingBlock,
            ContentBlockVariants::BetaToolUseBlock(var betaToolUseBlock) => betaToolUseBlock,
            ContentBlockVariants::BetaServerToolUseBlock(var betaServerToolUseBlock) =>
                betaServerToolUseBlock,
            ContentBlockVariants::BetaWebSearchToolResultBlock(var betaWebSearchToolResultBlock) =>
                betaWebSearchToolResultBlock,
            ContentBlockVariants::BetaCodeExecutionToolResultBlock(
                var betaCodeExecutionToolResultBlock
            ) => betaCodeExecutionToolResultBlock,
            ContentBlockVariants::BetaMCPToolUseBlock(var betaMCPToolUseBlock) =>
                betaMCPToolUseBlock,
            ContentBlockVariants::BetaMCPToolResultBlock(var betaMCPToolResultBlock) =>
                betaMCPToolResultBlock,
            ContentBlockVariants::BetaContainerUploadBlock(var betaContainerUploadBlock) =>
                betaContainerUploadBlock,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
