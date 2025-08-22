using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using BetaCodeExecutionToolResultBlockParamContentVariants = Anthropic.Models.Beta.Messages.BetaCodeExecutionToolResultBlockParamContentVariants;

namespace Anthropic.Models.Beta.Messages;

[JsonConverter(typeof(BetaCodeExecutionToolResultBlockParamContentConverter))]
public abstract record class BetaCodeExecutionToolResultBlockParamContent
{
    internal BetaCodeExecutionToolResultBlockParamContent() { }

    public static implicit operator BetaCodeExecutionToolResultBlockParamContent(
        BetaCodeExecutionToolResultErrorParam value
    ) =>
        new BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionToolResultErrorParam(
            value
        );

    public static implicit operator BetaCodeExecutionToolResultBlockParamContent(
        BetaCodeExecutionResultBlockParam value
    ) =>
        new BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionResultBlockParam(
            value
        );

    public bool TryPickBetaCodeExecutionToolResultErrorParam(
        [NotNullWhen(true)] out BetaCodeExecutionToolResultErrorParam? value
    )
    {
        value = (
            this
            as BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionToolResultErrorParam
        )?.Value;
        return value != null;
    }

    public bool TryPickBetaCodeExecutionResultBlockParam(
        [NotNullWhen(true)] out BetaCodeExecutionResultBlockParam? value
    )
    {
        value = (
            this
            as BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionResultBlockParam
        )?.Value;
        return value != null;
    }

    public void Switch(
        Action<BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionToolResultErrorParam> betaCodeExecutionToolResultErrorParam,
        Action<BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionResultBlockParam> betaCodeExecutionResultBlockParam
    )
    {
        switch (this)
        {
            case BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionToolResultErrorParam inner:
                betaCodeExecutionToolResultErrorParam(inner);
                break;
            case BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionResultBlockParam inner:
                betaCodeExecutionResultBlockParam(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<
            BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionToolResultErrorParam,
            T
        > betaCodeExecutionToolResultErrorParam,
        Func<
            BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionResultBlockParam,
            T
        > betaCodeExecutionResultBlockParam
    )
    {
        return this switch
        {
            BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionToolResultErrorParam inner =>
                betaCodeExecutionToolResultErrorParam(inner),
            BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionResultBlockParam inner =>
                betaCodeExecutionResultBlockParam(inner),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class BetaCodeExecutionToolResultBlockParamContentConverter
    : JsonConverter<BetaCodeExecutionToolResultBlockParamContent>
{
    public override BetaCodeExecutionToolResultBlockParamContent? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        List<JsonException> exceptions = [];

        try
        {
            var deserialized = JsonSerializer.Deserialize<BetaCodeExecutionToolResultErrorParam>(
                ref reader,
                options
            );
            if (deserialized != null)
            {
                return new BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionToolResultErrorParam(
                    deserialized
                );
            }
        }
        catch (JsonException e)
        {
            exceptions.Add(e);
        }

        try
        {
            var deserialized = JsonSerializer.Deserialize<BetaCodeExecutionResultBlockParam>(
                ref reader,
                options
            );
            if (deserialized != null)
            {
                return new BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionResultBlockParam(
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

    public override void Write(
        Utf8JsonWriter writer,
        BetaCodeExecutionToolResultBlockParamContent value,
        JsonSerializerOptions options
    )
    {
        object variant = value switch
        {
            BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionToolResultErrorParam(
                var betaCodeExecutionToolResultErrorParam
            ) => betaCodeExecutionToolResultErrorParam,
            BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionResultBlockParam(
                var betaCodeExecutionResultBlockParam
            ) => betaCodeExecutionResultBlockParam,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
