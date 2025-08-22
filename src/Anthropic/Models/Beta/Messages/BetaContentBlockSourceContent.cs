using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using BetaContentBlockSourceContentVariants = Anthropic.Models.Beta.Messages.BetaContentBlockSourceContentVariants;

namespace Anthropic.Models.Beta.Messages;

[JsonConverter(typeof(BetaContentBlockSourceContentConverter))]
public abstract record class BetaContentBlockSourceContent
{
    internal BetaContentBlockSourceContent() { }

    public static implicit operator BetaContentBlockSourceContent(BetaTextBlockParam value) =>
        new BetaContentBlockSourceContentVariants::BetaTextBlockParam(value);

    public static implicit operator BetaContentBlockSourceContent(BetaImageBlockParam value) =>
        new BetaContentBlockSourceContentVariants::BetaImageBlockParam(value);

    public bool TryPickBetaTextBlockParam([NotNullWhen(true)] out BetaTextBlockParam? value)
    {
        value = (this as BetaContentBlockSourceContentVariants::BetaTextBlockParam)?.Value;
        return value != null;
    }

    public bool TryPickBetaImageBlockParam([NotNullWhen(true)] out BetaImageBlockParam? value)
    {
        value = (this as BetaContentBlockSourceContentVariants::BetaImageBlockParam)?.Value;
        return value != null;
    }

    public void Switch(
        Action<BetaContentBlockSourceContentVariants::BetaTextBlockParam> betaTextBlockParam,
        Action<BetaContentBlockSourceContentVariants::BetaImageBlockParam> betaImageBlockParam
    )
    {
        switch (this)
        {
            case BetaContentBlockSourceContentVariants::BetaTextBlockParam inner:
                betaTextBlockParam(inner);
                break;
            case BetaContentBlockSourceContentVariants::BetaImageBlockParam inner:
                betaImageBlockParam(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<BetaContentBlockSourceContentVariants::BetaTextBlockParam, T> betaTextBlockParam,
        Func<BetaContentBlockSourceContentVariants::BetaImageBlockParam, T> betaImageBlockParam
    )
    {
        return this switch
        {
            BetaContentBlockSourceContentVariants::BetaTextBlockParam inner => betaTextBlockParam(
                inner
            ),
            BetaContentBlockSourceContentVariants::BetaImageBlockParam inner => betaImageBlockParam(
                inner
            ),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class BetaContentBlockSourceContentConverter : JsonConverter<BetaContentBlockSourceContent>
{
    public override BetaContentBlockSourceContent? Read(
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
                        return new BetaContentBlockSourceContentVariants::BetaTextBlockParam(
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
                        return new BetaContentBlockSourceContentVariants::BetaImageBlockParam(
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
        BetaContentBlockSourceContent value,
        JsonSerializerOptions options
    )
    {
        object variant = value switch
        {
            BetaContentBlockSourceContentVariants::BetaTextBlockParam(var betaTextBlockParam) =>
                betaTextBlockParam,
            BetaContentBlockSourceContentVariants::BetaImageBlockParam(var betaImageBlockParam) =>
                betaImageBlockParam,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
