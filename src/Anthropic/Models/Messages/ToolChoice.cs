using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ToolChoiceVariants = Anthropic.Models.Messages.ToolChoiceVariants;

namespace Anthropic.Models.Messages;

/// <summary>
/// How the model should use the provided tools. The model can use a specific tool,
/// any available tool, decide by itself, or not use tools at all.
/// </summary>
[JsonConverter(typeof(ToolChoiceConverter))]
public abstract record class ToolChoice
{
    internal ToolChoice() { }

    public static implicit operator ToolChoice(ToolChoiceAuto value) =>
        new ToolChoiceVariants::ToolChoiceAuto(value);

    public static implicit operator ToolChoice(ToolChoiceAny value) =>
        new ToolChoiceVariants::ToolChoiceAny(value);

    public static implicit operator ToolChoice(ToolChoiceTool value) =>
        new ToolChoiceVariants::ToolChoiceTool(value);

    public static implicit operator ToolChoice(ToolChoiceNone value) =>
        new ToolChoiceVariants::ToolChoiceNone(value);

    public bool TryPickToolChoiceAuto([NotNullWhen(true)] out ToolChoiceAuto? value)
    {
        value = (this as ToolChoiceVariants::ToolChoiceAuto)?.Value;
        return value != null;
    }

    public bool TryPickToolChoiceAny([NotNullWhen(true)] out ToolChoiceAny? value)
    {
        value = (this as ToolChoiceVariants::ToolChoiceAny)?.Value;
        return value != null;
    }

    public bool TryPickToolChoiceTool([NotNullWhen(true)] out ToolChoiceTool? value)
    {
        value = (this as ToolChoiceVariants::ToolChoiceTool)?.Value;
        return value != null;
    }

    public bool TryPickToolChoiceNone([NotNullWhen(true)] out ToolChoiceNone? value)
    {
        value = (this as ToolChoiceVariants::ToolChoiceNone)?.Value;
        return value != null;
    }

    public void Switch(
        Action<ToolChoiceVariants::ToolChoiceAuto> toolChoiceAuto,
        Action<ToolChoiceVariants::ToolChoiceAny> toolChoiceAny,
        Action<ToolChoiceVariants::ToolChoiceTool> toolChoiceTool,
        Action<ToolChoiceVariants::ToolChoiceNone> toolChoiceNone
    )
    {
        switch (this)
        {
            case ToolChoiceVariants::ToolChoiceAuto inner:
                toolChoiceAuto(inner);
                break;
            case ToolChoiceVariants::ToolChoiceAny inner:
                toolChoiceAny(inner);
                break;
            case ToolChoiceVariants::ToolChoiceTool inner:
                toolChoiceTool(inner);
                break;
            case ToolChoiceVariants::ToolChoiceNone inner:
                toolChoiceNone(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<ToolChoiceVariants::ToolChoiceAuto, T> toolChoiceAuto,
        Func<ToolChoiceVariants::ToolChoiceAny, T> toolChoiceAny,
        Func<ToolChoiceVariants::ToolChoiceTool, T> toolChoiceTool,
        Func<ToolChoiceVariants::ToolChoiceNone, T> toolChoiceNone
    )
    {
        return this switch
        {
            ToolChoiceVariants::ToolChoiceAuto inner => toolChoiceAuto(inner),
            ToolChoiceVariants::ToolChoiceAny inner => toolChoiceAny(inner),
            ToolChoiceVariants::ToolChoiceTool inner => toolChoiceTool(inner),
            ToolChoiceVariants::ToolChoiceNone inner => toolChoiceNone(inner),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class ToolChoiceConverter : JsonConverter<ToolChoice>
{
    public override ToolChoice? Read(
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
            case "auto":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<ToolChoiceAuto>(json, options);
                    if (deserialized != null)
                    {
                        return new ToolChoiceVariants::ToolChoiceAuto(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "any":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<ToolChoiceAny>(json, options);
                    if (deserialized != null)
                    {
                        return new ToolChoiceVariants::ToolChoiceAny(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "tool":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<ToolChoiceTool>(json, options);
                    if (deserialized != null)
                    {
                        return new ToolChoiceVariants::ToolChoiceTool(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "none":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<ToolChoiceNone>(json, options);
                    if (deserialized != null)
                    {
                        return new ToolChoiceVariants::ToolChoiceNone(deserialized);
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
        ToolChoice value,
        JsonSerializerOptions options
    )
    {
        object variant = value switch
        {
            ToolChoiceVariants::ToolChoiceAuto(var toolChoiceAuto) => toolChoiceAuto,
            ToolChoiceVariants::ToolChoiceAny(var toolChoiceAny) => toolChoiceAny,
            ToolChoiceVariants::ToolChoiceTool(var toolChoiceTool) => toolChoiceTool,
            ToolChoiceVariants::ToolChoiceNone(var toolChoiceNone) => toolChoiceNone,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
