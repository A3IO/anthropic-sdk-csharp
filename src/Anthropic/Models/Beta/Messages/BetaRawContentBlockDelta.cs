using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using BetaRawContentBlockDeltaVariants = Anthropic.Models.Beta.Messages.BetaRawContentBlockDeltaVariants;

namespace Anthropic.Models.Beta.Messages;

[JsonConverter(typeof(BetaRawContentBlockDeltaConverter))]
public abstract record class BetaRawContentBlockDelta
{
    internal BetaRawContentBlockDelta() { }

    public static implicit operator BetaRawContentBlockDelta(BetaTextDelta value) =>
        new BetaRawContentBlockDeltaVariants::BetaTextDelta(value);

    public static implicit operator BetaRawContentBlockDelta(BetaInputJSONDelta value) =>
        new BetaRawContentBlockDeltaVariants::BetaInputJSONDelta(value);

    public static implicit operator BetaRawContentBlockDelta(BetaCitationsDelta value) =>
        new BetaRawContentBlockDeltaVariants::BetaCitationsDelta(value);

    public static implicit operator BetaRawContentBlockDelta(BetaThinkingDelta value) =>
        new BetaRawContentBlockDeltaVariants::BetaThinkingDelta(value);

    public static implicit operator BetaRawContentBlockDelta(BetaSignatureDelta value) =>
        new BetaRawContentBlockDeltaVariants::BetaSignatureDelta(value);

    public bool TryPickBetaTextDelta([NotNullWhen(true)] out BetaTextDelta? value)
    {
        value = (this as BetaRawContentBlockDeltaVariants::BetaTextDelta)?.Value;
        return value != null;
    }

    public bool TryPickBetaInputJSONDelta([NotNullWhen(true)] out BetaInputJSONDelta? value)
    {
        value = (this as BetaRawContentBlockDeltaVariants::BetaInputJSONDelta)?.Value;
        return value != null;
    }

    public bool TryPickBetaCitationsDelta([NotNullWhen(true)] out BetaCitationsDelta? value)
    {
        value = (this as BetaRawContentBlockDeltaVariants::BetaCitationsDelta)?.Value;
        return value != null;
    }

    public bool TryPickBetaThinkingDelta([NotNullWhen(true)] out BetaThinkingDelta? value)
    {
        value = (this as BetaRawContentBlockDeltaVariants::BetaThinkingDelta)?.Value;
        return value != null;
    }

    public bool TryPickBetaSignatureDelta([NotNullWhen(true)] out BetaSignatureDelta? value)
    {
        value = (this as BetaRawContentBlockDeltaVariants::BetaSignatureDelta)?.Value;
        return value != null;
    }

    public void Switch(
        Action<BetaRawContentBlockDeltaVariants::BetaTextDelta> betaTextDelta,
        Action<BetaRawContentBlockDeltaVariants::BetaInputJSONDelta> betaInputJSONDelta,
        Action<BetaRawContentBlockDeltaVariants::BetaCitationsDelta> betaCitationsDelta,
        Action<BetaRawContentBlockDeltaVariants::BetaThinkingDelta> betaThinkingDelta,
        Action<BetaRawContentBlockDeltaVariants::BetaSignatureDelta> betaSignatureDelta
    )
    {
        switch (this)
        {
            case BetaRawContentBlockDeltaVariants::BetaTextDelta inner:
                betaTextDelta(inner);
                break;
            case BetaRawContentBlockDeltaVariants::BetaInputJSONDelta inner:
                betaInputJSONDelta(inner);
                break;
            case BetaRawContentBlockDeltaVariants::BetaCitationsDelta inner:
                betaCitationsDelta(inner);
                break;
            case BetaRawContentBlockDeltaVariants::BetaThinkingDelta inner:
                betaThinkingDelta(inner);
                break;
            case BetaRawContentBlockDeltaVariants::BetaSignatureDelta inner:
                betaSignatureDelta(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<BetaRawContentBlockDeltaVariants::BetaTextDelta, T> betaTextDelta,
        Func<BetaRawContentBlockDeltaVariants::BetaInputJSONDelta, T> betaInputJSONDelta,
        Func<BetaRawContentBlockDeltaVariants::BetaCitationsDelta, T> betaCitationsDelta,
        Func<BetaRawContentBlockDeltaVariants::BetaThinkingDelta, T> betaThinkingDelta,
        Func<BetaRawContentBlockDeltaVariants::BetaSignatureDelta, T> betaSignatureDelta
    )
    {
        return this switch
        {
            BetaRawContentBlockDeltaVariants::BetaTextDelta inner => betaTextDelta(inner),
            BetaRawContentBlockDeltaVariants::BetaInputJSONDelta inner => betaInputJSONDelta(inner),
            BetaRawContentBlockDeltaVariants::BetaCitationsDelta inner => betaCitationsDelta(inner),
            BetaRawContentBlockDeltaVariants::BetaThinkingDelta inner => betaThinkingDelta(inner),
            BetaRawContentBlockDeltaVariants::BetaSignatureDelta inner => betaSignatureDelta(inner),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class BetaRawContentBlockDeltaConverter : JsonConverter<BetaRawContentBlockDelta>
{
    public override BetaRawContentBlockDelta? Read(
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
            case "text_delta":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaTextDelta>(json, options);
                    if (deserialized != null)
                    {
                        return new BetaRawContentBlockDeltaVariants::BetaTextDelta(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "input_json_delta":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaInputJSONDelta>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaRawContentBlockDeltaVariants::BetaInputJSONDelta(
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
            case "citations_delta":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaCitationsDelta>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaRawContentBlockDeltaVariants::BetaCitationsDelta(
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
            case "thinking_delta":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaThinkingDelta>(json, options);
                    if (deserialized != null)
                    {
                        return new BetaRawContentBlockDeltaVariants::BetaThinkingDelta(
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
            case "signature_delta":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaSignatureDelta>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaRawContentBlockDeltaVariants::BetaSignatureDelta(
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
        BetaRawContentBlockDelta value,
        JsonSerializerOptions options
    )
    {
        object variant = value switch
        {
            BetaRawContentBlockDeltaVariants::BetaTextDelta(var betaTextDelta) => betaTextDelta,
            BetaRawContentBlockDeltaVariants::BetaInputJSONDelta(var betaInputJSONDelta) =>
                betaInputJSONDelta,
            BetaRawContentBlockDeltaVariants::BetaCitationsDelta(var betaCitationsDelta) =>
                betaCitationsDelta,
            BetaRawContentBlockDeltaVariants::BetaThinkingDelta(var betaThinkingDelta) =>
                betaThinkingDelta,
            BetaRawContentBlockDeltaVariants::BetaSignatureDelta(var betaSignatureDelta) =>
                betaSignatureDelta,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
