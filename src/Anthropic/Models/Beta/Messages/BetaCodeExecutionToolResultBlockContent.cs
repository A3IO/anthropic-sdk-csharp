using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using BetaCodeExecutionToolResultBlockContentVariants = Anthropic.Models.Beta.Messages.BetaCodeExecutionToolResultBlockContentVariants;

namespace Anthropic.Models.Beta.Messages;

[JsonConverter(typeof(BetaCodeExecutionToolResultBlockContentConverter))]
public abstract record class BetaCodeExecutionToolResultBlockContent
{
    internal BetaCodeExecutionToolResultBlockContent() { }

    public static implicit operator BetaCodeExecutionToolResultBlockContent(
        BetaCodeExecutionToolResultError value
    ) =>
        new BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionToolResultError(
            value
        );

    public static implicit operator BetaCodeExecutionToolResultBlockContent(
        BetaCodeExecutionResultBlock value
    ) => new BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionResultBlock(value);

    public bool TryPickBetaCodeExecutionToolResultError(
        [NotNullWhen(true)] out BetaCodeExecutionToolResultError? value
    )
    {
        value = (
            this
            as BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionToolResultError
        )?.Value;
        return value != null;
    }

    public bool TryPickBetaCodeExecutionResultBlock(
        [NotNullWhen(true)] out BetaCodeExecutionResultBlock? value
    )
    {
        value = (
            this as BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionResultBlock
        )?.Value;
        return value != null;
    }

    public void Switch(
        Action<BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionToolResultError> betaCodeExecutionToolResultError,
        Action<BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionResultBlock> betaCodeExecutionResultBlock
    )
    {
        switch (this)
        {
            case BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionToolResultError inner:
                betaCodeExecutionToolResultError(inner);
                break;
            case BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionResultBlock inner:
                betaCodeExecutionResultBlock(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<
            BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionToolResultError,
            T
        > betaCodeExecutionToolResultError,
        Func<
            BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionResultBlock,
            T
        > betaCodeExecutionResultBlock
    )
    {
        return this switch
        {
            BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionToolResultError inner =>
                betaCodeExecutionToolResultError(inner),
            BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionResultBlock inner =>
                betaCodeExecutionResultBlock(inner),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class BetaCodeExecutionToolResultBlockContentConverter
    : JsonConverter<BetaCodeExecutionToolResultBlockContent>
{
    public override BetaCodeExecutionToolResultBlockContent? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        List<JsonException> exceptions = [];

        try
        {
            var deserialized = JsonSerializer.Deserialize<BetaCodeExecutionToolResultError>(
                ref reader,
                options
            );
            if (deserialized != null)
            {
                return new BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionToolResultError(
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
            var deserialized = JsonSerializer.Deserialize<BetaCodeExecutionResultBlock>(
                ref reader,
                options
            );
            if (deserialized != null)
            {
                return new BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionResultBlock(
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
        BetaCodeExecutionToolResultBlockContent value,
        JsonSerializerOptions options
    )
    {
        object variant = value switch
        {
            BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionToolResultError(
                var betaCodeExecutionToolResultError
            ) => betaCodeExecutionToolResultError,
            BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionResultBlock(
                var betaCodeExecutionResultBlock
            ) => betaCodeExecutionResultBlock,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
