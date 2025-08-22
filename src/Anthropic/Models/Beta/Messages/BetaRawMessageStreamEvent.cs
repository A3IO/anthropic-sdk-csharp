using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using BetaRawMessageStreamEventVariants = Anthropic.Models.Beta.Messages.BetaRawMessageStreamEventVariants;

namespace Anthropic.Models.Beta.Messages;

[JsonConverter(typeof(BetaRawMessageStreamEventConverter))]
public abstract record class BetaRawMessageStreamEvent
{
    internal BetaRawMessageStreamEvent() { }

    public static implicit operator BetaRawMessageStreamEvent(BetaRawMessageStartEvent value) =>
        new BetaRawMessageStreamEventVariants::BetaRawMessageStartEvent(value);

    public static implicit operator BetaRawMessageStreamEvent(BetaRawMessageDeltaEvent value) =>
        new BetaRawMessageStreamEventVariants::BetaRawMessageDeltaEvent(value);

    public static implicit operator BetaRawMessageStreamEvent(BetaRawMessageStopEvent value) =>
        new BetaRawMessageStreamEventVariants::BetaRawMessageStopEvent(value);

    public static implicit operator BetaRawMessageStreamEvent(
        BetaRawContentBlockStartEvent value
    ) => new BetaRawMessageStreamEventVariants::BetaRawContentBlockStartEvent(value);

    public static implicit operator BetaRawMessageStreamEvent(
        BetaRawContentBlockDeltaEvent value
    ) => new BetaRawMessageStreamEventVariants::BetaRawContentBlockDeltaEvent(value);

    public static implicit operator BetaRawMessageStreamEvent(BetaRawContentBlockStopEvent value) =>
        new BetaRawMessageStreamEventVariants::BetaRawContentBlockStopEvent(value);

    public bool TryPickBetaRawMessageStartEvent(
        [NotNullWhen(true)] out BetaRawMessageStartEvent? value
    )
    {
        value = (this as BetaRawMessageStreamEventVariants::BetaRawMessageStartEvent)?.Value;
        return value != null;
    }

    public bool TryPickBetaRawMessageDeltaEvent(
        [NotNullWhen(true)] out BetaRawMessageDeltaEvent? value
    )
    {
        value = (this as BetaRawMessageStreamEventVariants::BetaRawMessageDeltaEvent)?.Value;
        return value != null;
    }

    public bool TryPickBetaRawMessageStopEvent(
        [NotNullWhen(true)] out BetaRawMessageStopEvent? value
    )
    {
        value = (this as BetaRawMessageStreamEventVariants::BetaRawMessageStopEvent)?.Value;
        return value != null;
    }

    public bool TryPickBetaRawContentBlockStartEvent(
        [NotNullWhen(true)] out BetaRawContentBlockStartEvent? value
    )
    {
        value = (this as BetaRawMessageStreamEventVariants::BetaRawContentBlockStartEvent)?.Value;
        return value != null;
    }

    public bool TryPickBetaRawContentBlockDeltaEvent(
        [NotNullWhen(true)] out BetaRawContentBlockDeltaEvent? value
    )
    {
        value = (this as BetaRawMessageStreamEventVariants::BetaRawContentBlockDeltaEvent)?.Value;
        return value != null;
    }

    public bool TryPickBetaRawContentBlockStopEvent(
        [NotNullWhen(true)] out BetaRawContentBlockStopEvent? value
    )
    {
        value = (this as BetaRawMessageStreamEventVariants::BetaRawContentBlockStopEvent)?.Value;
        return value != null;
    }

    public void Switch(
        Action<BetaRawMessageStreamEventVariants::BetaRawMessageStartEvent> betaRawMessageStartEvent,
        Action<BetaRawMessageStreamEventVariants::BetaRawMessageDeltaEvent> betaRawMessageDeltaEvent,
        Action<BetaRawMessageStreamEventVariants::BetaRawMessageStopEvent> betaRawMessageStopEvent,
        Action<BetaRawMessageStreamEventVariants::BetaRawContentBlockStartEvent> betaRawContentBlockStartEvent,
        Action<BetaRawMessageStreamEventVariants::BetaRawContentBlockDeltaEvent> betaRawContentBlockDeltaEvent,
        Action<BetaRawMessageStreamEventVariants::BetaRawContentBlockStopEvent> betaRawContentBlockStopEvent
    )
    {
        switch (this)
        {
            case BetaRawMessageStreamEventVariants::BetaRawMessageStartEvent inner:
                betaRawMessageStartEvent(inner);
                break;
            case BetaRawMessageStreamEventVariants::BetaRawMessageDeltaEvent inner:
                betaRawMessageDeltaEvent(inner);
                break;
            case BetaRawMessageStreamEventVariants::BetaRawMessageStopEvent inner:
                betaRawMessageStopEvent(inner);
                break;
            case BetaRawMessageStreamEventVariants::BetaRawContentBlockStartEvent inner:
                betaRawContentBlockStartEvent(inner);
                break;
            case BetaRawMessageStreamEventVariants::BetaRawContentBlockDeltaEvent inner:
                betaRawContentBlockDeltaEvent(inner);
                break;
            case BetaRawMessageStreamEventVariants::BetaRawContentBlockStopEvent inner:
                betaRawContentBlockStopEvent(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<
            BetaRawMessageStreamEventVariants::BetaRawMessageStartEvent,
            T
        > betaRawMessageStartEvent,
        Func<
            BetaRawMessageStreamEventVariants::BetaRawMessageDeltaEvent,
            T
        > betaRawMessageDeltaEvent,
        Func<BetaRawMessageStreamEventVariants::BetaRawMessageStopEvent, T> betaRawMessageStopEvent,
        Func<
            BetaRawMessageStreamEventVariants::BetaRawContentBlockStartEvent,
            T
        > betaRawContentBlockStartEvent,
        Func<
            BetaRawMessageStreamEventVariants::BetaRawContentBlockDeltaEvent,
            T
        > betaRawContentBlockDeltaEvent,
        Func<
            BetaRawMessageStreamEventVariants::BetaRawContentBlockStopEvent,
            T
        > betaRawContentBlockStopEvent
    )
    {
        return this switch
        {
            BetaRawMessageStreamEventVariants::BetaRawMessageStartEvent inner =>
                betaRawMessageStartEvent(inner),
            BetaRawMessageStreamEventVariants::BetaRawMessageDeltaEvent inner =>
                betaRawMessageDeltaEvent(inner),
            BetaRawMessageStreamEventVariants::BetaRawMessageStopEvent inner =>
                betaRawMessageStopEvent(inner),
            BetaRawMessageStreamEventVariants::BetaRawContentBlockStartEvent inner =>
                betaRawContentBlockStartEvent(inner),
            BetaRawMessageStreamEventVariants::BetaRawContentBlockDeltaEvent inner =>
                betaRawContentBlockDeltaEvent(inner),
            BetaRawMessageStreamEventVariants::BetaRawContentBlockStopEvent inner =>
                betaRawContentBlockStopEvent(inner),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class BetaRawMessageStreamEventConverter : JsonConverter<BetaRawMessageStreamEvent>
{
    public override BetaRawMessageStreamEvent? Read(
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
            case "message_start":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaRawMessageStartEvent>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaRawMessageStreamEventVariants::BetaRawMessageStartEvent(
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
            case "message_delta":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaRawMessageDeltaEvent>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaRawMessageStreamEventVariants::BetaRawMessageDeltaEvent(
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
            case "message_stop":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaRawMessageStopEvent>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaRawMessageStreamEventVariants::BetaRawMessageStopEvent(
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
            case "content_block_start":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaRawContentBlockStartEvent>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaRawMessageStreamEventVariants::BetaRawContentBlockStartEvent(
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
            case "content_block_delta":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaRawContentBlockDeltaEvent>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaRawMessageStreamEventVariants::BetaRawContentBlockDeltaEvent(
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
            case "content_block_stop":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaRawContentBlockStopEvent>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaRawMessageStreamEventVariants::BetaRawContentBlockStopEvent(
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
        BetaRawMessageStreamEvent value,
        JsonSerializerOptions options
    )
    {
        object variant = value switch
        {
            BetaRawMessageStreamEventVariants::BetaRawMessageStartEvent(
                var betaRawMessageStartEvent
            ) => betaRawMessageStartEvent,
            BetaRawMessageStreamEventVariants::BetaRawMessageDeltaEvent(
                var betaRawMessageDeltaEvent
            ) => betaRawMessageDeltaEvent,
            BetaRawMessageStreamEventVariants::BetaRawMessageStopEvent(
                var betaRawMessageStopEvent
            ) => betaRawMessageStopEvent,
            BetaRawMessageStreamEventVariants::BetaRawContentBlockStartEvent(
                var betaRawContentBlockStartEvent
            ) => betaRawContentBlockStartEvent,
            BetaRawMessageStreamEventVariants::BetaRawContentBlockDeltaEvent(
                var betaRawContentBlockDeltaEvent
            ) => betaRawContentBlockDeltaEvent,
            BetaRawMessageStreamEventVariants::BetaRawContentBlockStopEvent(
                var betaRawContentBlockStopEvent
            ) => betaRawContentBlockStopEvent,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
