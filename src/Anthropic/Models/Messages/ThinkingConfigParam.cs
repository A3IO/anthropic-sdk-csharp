using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using ThinkingConfigParamVariants = Anthropic.Models.Messages.ThinkingConfigParamVariants;

namespace Anthropic.Models.Messages;

/// <summary>
/// Configuration for enabling Claude's extended thinking.
///
/// When enabled, responses include `thinking` content blocks showing Claude's thinking
/// process before the final answer. Requires a minimum budget of 1,024 tokens and
/// counts towards your `max_tokens` limit.
///
/// See [extended thinking](https://docs.anthropic.com/en/docs/build-with-claude/extended-thinking)
/// for details.
/// </summary>
[JsonConverter(typeof(ThinkingConfigParamConverter))]
public abstract record class ThinkingConfigParam
{
    internal ThinkingConfigParam() { }

    public static implicit operator ThinkingConfigParam(ThinkingConfigEnabled value) =>
        new ThinkingConfigParamVariants::ThinkingConfigEnabled(value);

    public static implicit operator ThinkingConfigParam(ThinkingConfigDisabled value) =>
        new ThinkingConfigParamVariants::ThinkingConfigDisabled(value);

    public bool TryPickThinkingConfigEnabled([NotNullWhen(true)] out ThinkingConfigEnabled? value)
    {
        value = (this as ThinkingConfigParamVariants::ThinkingConfigEnabled)?.Value;
        return value != null;
    }

    public bool TryPickThinkingConfigDisabled([NotNullWhen(true)] out ThinkingConfigDisabled? value)
    {
        value = (this as ThinkingConfigParamVariants::ThinkingConfigDisabled)?.Value;
        return value != null;
    }

    public void Switch(
        Action<ThinkingConfigParamVariants::ThinkingConfigEnabled> thinkingConfigEnabled,
        Action<ThinkingConfigParamVariants::ThinkingConfigDisabled> thinkingConfigDisabled
    )
    {
        switch (this)
        {
            case ThinkingConfigParamVariants::ThinkingConfigEnabled inner:
                thinkingConfigEnabled(inner);
                break;
            case ThinkingConfigParamVariants::ThinkingConfigDisabled inner:
                thinkingConfigDisabled(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<ThinkingConfigParamVariants::ThinkingConfigEnabled, T> thinkingConfigEnabled,
        Func<ThinkingConfigParamVariants::ThinkingConfigDisabled, T> thinkingConfigDisabled
    )
    {
        return this switch
        {
            ThinkingConfigParamVariants::ThinkingConfigEnabled inner => thinkingConfigEnabled(
                inner
            ),
            ThinkingConfigParamVariants::ThinkingConfigDisabled inner => thinkingConfigDisabled(
                inner
            ),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class ThinkingConfigParamConverter : JsonConverter<ThinkingConfigParam>
{
    public override ThinkingConfigParam? Read(
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
            case "enabled":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<ThinkingConfigEnabled>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new ThinkingConfigParamVariants::ThinkingConfigEnabled(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "disabled":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<ThinkingConfigDisabled>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new ThinkingConfigParamVariants::ThinkingConfigDisabled(
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
        ThinkingConfigParam value,
        JsonSerializerOptions options
    )
    {
        object variant = value switch
        {
            ThinkingConfigParamVariants::ThinkingConfigEnabled(var thinkingConfigEnabled) =>
                thinkingConfigEnabled,
            ThinkingConfigParamVariants::ThinkingConfigDisabled(var thinkingConfigDisabled) =>
                thinkingConfigDisabled,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
