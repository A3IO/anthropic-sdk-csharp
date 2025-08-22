using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ContentBlockParamVariants = Anthropic.Models.Messages.ContentBlockParamVariants;

namespace Anthropic.Models.Messages;

/// <summary>
/// Regular text content.
/// </summary>
[JsonConverter(typeof(ContentBlockParamConverter))]
public abstract record class ContentBlockParam
{
    internal ContentBlockParam() { }

    public static implicit operator ContentBlockParam(TextBlockParam value) =>
        new ContentBlockParamVariants::TextBlockParam(value);

    public static implicit operator ContentBlockParam(ImageBlockParam value) =>
        new ContentBlockParamVariants::ImageBlockParam(value);

    public static implicit operator ContentBlockParam(DocumentBlockParam value) =>
        new ContentBlockParamVariants::DocumentBlockParam(value);

    public static implicit operator ContentBlockParam(SearchResultBlockParam value) =>
        new ContentBlockParamVariants::SearchResultBlockParam(value);

    public static implicit operator ContentBlockParam(ThinkingBlockParam value) =>
        new ContentBlockParamVariants::ThinkingBlockParam(value);

    public static implicit operator ContentBlockParam(RedactedThinkingBlockParam value) =>
        new ContentBlockParamVariants::RedactedThinkingBlockParam(value);

    public static implicit operator ContentBlockParam(ToolUseBlockParam value) =>
        new ContentBlockParamVariants::ToolUseBlockParam(value);

    public static implicit operator ContentBlockParam(ToolResultBlockParam value) =>
        new ContentBlockParamVariants::ToolResultBlockParam(value);

    public static implicit operator ContentBlockParam(ServerToolUseBlockParam value) =>
        new ContentBlockParamVariants::ServerToolUseBlockParam(value);

    public static implicit operator ContentBlockParam(WebSearchToolResultBlockParam value) =>
        new ContentBlockParamVariants::WebSearchToolResultBlockParam(value);

    public bool TryPickTextBlockParam([NotNullWhen(true)] out TextBlockParam? value)
    {
        value = (this as ContentBlockParamVariants::TextBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickImageBlockParam([NotNullWhen(true)] out ImageBlockParam? value)
    {
        value = (this as ContentBlockParamVariants::ImageBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickDocumentBlockParam([NotNullWhen(true)] out DocumentBlockParam? value)
    {
        value = (this as ContentBlockParamVariants::DocumentBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickSearchResultBlockParam([NotNullWhen(true)] out SearchResultBlockParam? value)
    {
        value = (this as ContentBlockParamVariants::SearchResultBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickThinkingBlockParam([NotNullWhen(true)] out ThinkingBlockParam? value)
    {
        value = (this as ContentBlockParamVariants::ThinkingBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickRedactedThinkingBlockParam(
        [NotNullWhen(true)] out RedactedThinkingBlockParam? value
    )
    {
        value = (this as ContentBlockParamVariants::RedactedThinkingBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickToolUseBlockParam([NotNullWhen(true)] out ToolUseBlockParam? value)
    {
        value = (this as ContentBlockParamVariants::ToolUseBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickToolResultBlockParam([NotNullWhen(true)] out ToolResultBlockParam? value)
    {
        value = (this as ContentBlockParamVariants::ToolResultBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickServerToolUseBlockParam(
        [NotNullWhen(true)] out ServerToolUseBlockParam? value
    )
    {
        value = (this as ContentBlockParamVariants::ServerToolUseBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickWebSearchToolResultBlockParam(
        [NotNullWhen(true)] out WebSearchToolResultBlockParam? value
    )
    {
        value = (this as ContentBlockParamVariants::WebSearchToolResultBlockParam)?.Value;
        return value != null;
    }

    public void Switch(
        Action<ContentBlockParamVariants::TextBlockParam> textBlockParam,
        Action<ContentBlockParamVariants::ImageBlockParam> imageBlockParam,
        Action<ContentBlockParamVariants::DocumentBlockParam> documentBlockParam,
        Action<ContentBlockParamVariants::SearchResultBlockParam> searchResultBlockParam,
        Action<ContentBlockParamVariants::ThinkingBlockParam> thinkingBlockParam,
        Action<ContentBlockParamVariants::RedactedThinkingBlockParam> redactedThinkingBlockParam,
        Action<ContentBlockParamVariants::ToolUseBlockParam> toolUseBlockParam,
        Action<ContentBlockParamVariants::ToolResultBlockParam> toolResultBlockParam,
        Action<ContentBlockParamVariants::ServerToolUseBlockParam> serverToolUseBlockParam,
        Action<ContentBlockParamVariants::WebSearchToolResultBlockParam> webSearchToolResultBlockParam
    )
    {
        switch (this)
        {
            case ContentBlockParamVariants::TextBlockParam inner:
                textBlockParam(inner);
                break;
            case ContentBlockParamVariants::ImageBlockParam inner:
                imageBlockParam(inner);
                break;
            case ContentBlockParamVariants::DocumentBlockParam inner:
                documentBlockParam(inner);
                break;
            case ContentBlockParamVariants::SearchResultBlockParam inner:
                searchResultBlockParam(inner);
                break;
            case ContentBlockParamVariants::ThinkingBlockParam inner:
                thinkingBlockParam(inner);
                break;
            case ContentBlockParamVariants::RedactedThinkingBlockParam inner:
                redactedThinkingBlockParam(inner);
                break;
            case ContentBlockParamVariants::ToolUseBlockParam inner:
                toolUseBlockParam(inner);
                break;
            case ContentBlockParamVariants::ToolResultBlockParam inner:
                toolResultBlockParam(inner);
                break;
            case ContentBlockParamVariants::ServerToolUseBlockParam inner:
                serverToolUseBlockParam(inner);
                break;
            case ContentBlockParamVariants::WebSearchToolResultBlockParam inner:
                webSearchToolResultBlockParam(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<ContentBlockParamVariants::TextBlockParam, T> textBlockParam,
        Func<ContentBlockParamVariants::ImageBlockParam, T> imageBlockParam,
        Func<ContentBlockParamVariants::DocumentBlockParam, T> documentBlockParam,
        Func<ContentBlockParamVariants::SearchResultBlockParam, T> searchResultBlockParam,
        Func<ContentBlockParamVariants::ThinkingBlockParam, T> thinkingBlockParam,
        Func<ContentBlockParamVariants::RedactedThinkingBlockParam, T> redactedThinkingBlockParam,
        Func<ContentBlockParamVariants::ToolUseBlockParam, T> toolUseBlockParam,
        Func<ContentBlockParamVariants::ToolResultBlockParam, T> toolResultBlockParam,
        Func<ContentBlockParamVariants::ServerToolUseBlockParam, T> serverToolUseBlockParam,
        Func<
            ContentBlockParamVariants::WebSearchToolResultBlockParam,
            T
        > webSearchToolResultBlockParam
    )
    {
        return this switch
        {
            ContentBlockParamVariants::TextBlockParam inner => textBlockParam(inner),
            ContentBlockParamVariants::ImageBlockParam inner => imageBlockParam(inner),
            ContentBlockParamVariants::DocumentBlockParam inner => documentBlockParam(inner),
            ContentBlockParamVariants::SearchResultBlockParam inner => searchResultBlockParam(
                inner
            ),
            ContentBlockParamVariants::ThinkingBlockParam inner => thinkingBlockParam(inner),
            ContentBlockParamVariants::RedactedThinkingBlockParam inner =>
                redactedThinkingBlockParam(inner),
            ContentBlockParamVariants::ToolUseBlockParam inner => toolUseBlockParam(inner),
            ContentBlockParamVariants::ToolResultBlockParam inner => toolResultBlockParam(inner),
            ContentBlockParamVariants::ServerToolUseBlockParam inner => serverToolUseBlockParam(
                inner
            ),
            ContentBlockParamVariants::WebSearchToolResultBlockParam inner =>
                webSearchToolResultBlockParam(inner),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class ContentBlockParamConverter : JsonConverter<ContentBlockParam>
{
    public override ContentBlockParam? Read(
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
                    var deserialized = JsonSerializer.Deserialize<TextBlockParam>(json, options);
                    if (deserialized != null)
                    {
                        return new ContentBlockParamVariants::TextBlockParam(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<ImageBlockParam>(json, options);
                    if (deserialized != null)
                    {
                        return new ContentBlockParamVariants::ImageBlockParam(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<DocumentBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new ContentBlockParamVariants::DocumentBlockParam(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<SearchResultBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new ContentBlockParamVariants::SearchResultBlockParam(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<ThinkingBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new ContentBlockParamVariants::ThinkingBlockParam(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<RedactedThinkingBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new ContentBlockParamVariants::RedactedThinkingBlockParam(
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
                    var deserialized = JsonSerializer.Deserialize<ToolUseBlockParam>(json, options);
                    if (deserialized != null)
                    {
                        return new ContentBlockParamVariants::ToolUseBlockParam(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<ToolResultBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new ContentBlockParamVariants::ToolResultBlockParam(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<ServerToolUseBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new ContentBlockParamVariants::ServerToolUseBlockParam(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<WebSearchToolResultBlockParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new ContentBlockParamVariants::WebSearchToolResultBlockParam(
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
        ContentBlockParam value,
        JsonSerializerOptions options
    )
    {
        object variant = value switch
        {
            ContentBlockParamVariants::TextBlockParam(var textBlockParam) => textBlockParam,
            ContentBlockParamVariants::ImageBlockParam(var imageBlockParam) => imageBlockParam,
            ContentBlockParamVariants::DocumentBlockParam(var documentBlockParam) =>
                documentBlockParam,
            ContentBlockParamVariants::SearchResultBlockParam(var searchResultBlockParam) =>
                searchResultBlockParam,
            ContentBlockParamVariants::ThinkingBlockParam(var thinkingBlockParam) =>
                thinkingBlockParam,
            ContentBlockParamVariants::RedactedThinkingBlockParam(var redactedThinkingBlockParam) =>
                redactedThinkingBlockParam,
            ContentBlockParamVariants::ToolUseBlockParam(var toolUseBlockParam) =>
                toolUseBlockParam,
            ContentBlockParamVariants::ToolResultBlockParam(var toolResultBlockParam) =>
                toolResultBlockParam,
            ContentBlockParamVariants::ServerToolUseBlockParam(var serverToolUseBlockParam) =>
                serverToolUseBlockParam,
            ContentBlockParamVariants::WebSearchToolResultBlockParam(
                var webSearchToolResultBlockParam
            ) => webSearchToolResultBlockParam,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
