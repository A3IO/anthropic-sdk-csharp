using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages.Batches.BetaMessageBatchProperties;

/// <summary>
/// Object type.
///
/// For Message Batches, this is always `"message_batch"`.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type MessageBatch = new("message_batch");

    readonly string _value = value;

    public enum Value
    {
        MessageBatch,
    }

    public Value Known() =>
        _value switch
        {
            "message_batch" => Value.MessageBatch,
            _ => throw new System::ArgumentOutOfRangeException(nameof(_value)),
        };

    public string Raw()
    {
        return _value;
    }

    public void Validate()
    {
        Known();
    }

    public static Type FromRaw(string value)
    {
        return new(value);
    }
}
