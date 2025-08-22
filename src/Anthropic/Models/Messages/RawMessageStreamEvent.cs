using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using RawMessageStreamEventVariants = Anthropic.Models.Messages.RawMessageStreamEventVariants;

namespace Anthropic.Models.Messages;

[JsonConverter(typeof(RawMessageStreamEventConverter))]
public abstract record class RawMessageStreamEvent
{
    internal RawMessageStreamEvent() { }

    public static implicit operator RawMessageStreamEvent(RawMessageStartEvent value) =>
        new RawMessageStreamEventVariants::RawMessageStartEvent(value);

    public static implicit operator RawMessageStreamEvent(RawMessageDeltaEvent value) =>
        new RawMessageStreamEventVariants::RawMessageDeltaEvent(value);

    public static implicit operator RawMessageStreamEvent(RawMessageStopEvent value) =>
        new RawMessageStreamEventVariants::RawMessageStopEvent(value);

    public static implicit operator RawMessageStreamEvent(RawContentBlockStartEvent value) =>
        new RawMessageStreamEventVariants::RawContentBlockStartEvent(value);

    public static implicit operator RawMessageStreamEvent(RawContentBlockDeltaEvent value) =>
        new RawMessageStreamEventVariants::RawContentBlockDeltaEvent(value);

    public static implicit operator RawMessageStreamEvent(RawContentBlockStopEvent value) =>
        new RawMessageStreamEventVariants::RawContentBlockStopEvent(value);

    public bool TryPickRawMessageStartEvent([NotNullWhen(true)] out RawMessageStartEvent? value)
    {
        value = (this as RawMessageStreamEventVariants::RawMessageStartEvent)?.Value;
        return value != null;
    }

    public bool TryPickRawMessageDeltaEvent([NotNullWhen(true)] out RawMessageDeltaEvent? value)
    {
        value = (this as RawMessageStreamEventVariants::RawMessageDeltaEvent)?.Value;
        return value != null;
    }

    public bool TryPickRawMessageStopEvent([NotNullWhen(true)] out RawMessageStopEvent? value)
    {
        value = (this as RawMessageStreamEventVariants::RawMessageStopEvent)?.Value;
        return value != null;
    }

    public bool TryPickRawContentBlockStartEvent(
        [NotNullWhen(true)] out RawContentBlockStartEvent? value
    )
    {
        value = (this as RawMessageStreamEventVariants::RawContentBlockStartEvent)?.Value;
        return value != null;
    }

    public bool TryPickRawContentBlockDeltaEvent(
        [NotNullWhen(true)] out RawContentBlockDeltaEvent? value
    )
    {
        value = (this as RawMessageStreamEventVariants::RawContentBlockDeltaEvent)?.Value;
        return value != null;
    }

    public bool TryPickRawContentBlockStopEvent(
        [NotNullWhen(true)] out RawContentBlockStopEvent? value
    )
    {
        value = (this as RawMessageStreamEventVariants::RawContentBlockStopEvent)?.Value;
        return value != null;
    }

    public void Switch(
        Action<RawMessageStreamEventVariants::RawMessageStartEvent> rawMessageStartEvent,
        Action<RawMessageStreamEventVariants::RawMessageDeltaEvent> rawMessageDeltaEvent,
        Action<RawMessageStreamEventVariants::RawMessageStopEvent> rawMessageStopEvent,
        Action<RawMessageStreamEventVariants::RawContentBlockStartEvent> rawContentBlockStartEvent,
        Action<RawMessageStreamEventVariants::RawContentBlockDeltaEvent> rawContentBlockDeltaEvent,
        Action<RawMessageStreamEventVariants::RawContentBlockStopEvent> rawContentBlockStopEvent
    )
    {
        switch (this)
        {
            case RawMessageStreamEventVariants::RawMessageStartEvent inner:
                rawMessageStartEvent(inner);
                break;
            case RawMessageStreamEventVariants::RawMessageDeltaEvent inner:
                rawMessageDeltaEvent(inner);
                break;
            case RawMessageStreamEventVariants::RawMessageStopEvent inner:
                rawMessageStopEvent(inner);
                break;
            case RawMessageStreamEventVariants::RawContentBlockStartEvent inner:
                rawContentBlockStartEvent(inner);
                break;
            case RawMessageStreamEventVariants::RawContentBlockDeltaEvent inner:
                rawContentBlockDeltaEvent(inner);
                break;
            case RawMessageStreamEventVariants::RawContentBlockStopEvent inner:
                rawContentBlockStopEvent(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<RawMessageStreamEventVariants::RawMessageStartEvent, T> rawMessageStartEvent,
        Func<RawMessageStreamEventVariants::RawMessageDeltaEvent, T> rawMessageDeltaEvent,
        Func<RawMessageStreamEventVariants::RawMessageStopEvent, T> rawMessageStopEvent,
        Func<RawMessageStreamEventVariants::RawContentBlockStartEvent, T> rawContentBlockStartEvent,
        Func<RawMessageStreamEventVariants::RawContentBlockDeltaEvent, T> rawContentBlockDeltaEvent,
        Func<RawMessageStreamEventVariants::RawContentBlockStopEvent, T> rawContentBlockStopEvent
    )
    {
        return this switch
        {
            RawMessageStreamEventVariants::RawMessageStartEvent inner => rawMessageStartEvent(
                inner
            ),
            RawMessageStreamEventVariants::RawMessageDeltaEvent inner => rawMessageDeltaEvent(
                inner
            ),
            RawMessageStreamEventVariants::RawMessageStopEvent inner => rawMessageStopEvent(inner),
            RawMessageStreamEventVariants::RawContentBlockStartEvent inner =>
                rawContentBlockStartEvent(inner),
            RawMessageStreamEventVariants::RawContentBlockDeltaEvent inner =>
                rawContentBlockDeltaEvent(inner),
            RawMessageStreamEventVariants::RawContentBlockStopEvent inner =>
                rawContentBlockStopEvent(inner),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class RawMessageStreamEventConverter : JsonConverter<RawMessageStreamEvent>
{
    public override RawMessageStreamEvent? Read(
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
                    var deserialized = JsonSerializer.Deserialize<RawMessageStartEvent>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new RawMessageStreamEventVariants::RawMessageStartEvent(
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
                    var deserialized = JsonSerializer.Deserialize<RawMessageDeltaEvent>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new RawMessageStreamEventVariants::RawMessageDeltaEvent(
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
                    var deserialized = JsonSerializer.Deserialize<RawMessageStopEvent>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new RawMessageStreamEventVariants::RawMessageStopEvent(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<RawContentBlockStartEvent>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new RawMessageStreamEventVariants::RawContentBlockStartEvent(
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
                    var deserialized = JsonSerializer.Deserialize<RawContentBlockDeltaEvent>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new RawMessageStreamEventVariants::RawContentBlockDeltaEvent(
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
                    var deserialized = JsonSerializer.Deserialize<RawContentBlockStopEvent>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new RawMessageStreamEventVariants::RawContentBlockStopEvent(
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
        RawMessageStreamEvent value,
        JsonSerializerOptions options
    )
    {
        object variant = value switch
        {
            RawMessageStreamEventVariants::RawMessageStartEvent(var rawMessageStartEvent) =>
                rawMessageStartEvent,
            RawMessageStreamEventVariants::RawMessageDeltaEvent(var rawMessageDeltaEvent) =>
                rawMessageDeltaEvent,
            RawMessageStreamEventVariants::RawMessageStopEvent(var rawMessageStopEvent) =>
                rawMessageStopEvent,
            RawMessageStreamEventVariants::RawContentBlockStartEvent(
                var rawContentBlockStartEvent
            ) => rawContentBlockStartEvent,
            RawMessageStreamEventVariants::RawContentBlockDeltaEvent(
                var rawContentBlockDeltaEvent
            ) => rawContentBlockDeltaEvent,
            RawMessageStreamEventVariants::RawContentBlockStopEvent(var rawContentBlockStopEvent) =>
                rawContentBlockStopEvent,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
