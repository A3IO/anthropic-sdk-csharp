using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages.Batches.BetaDeletedMessageBatchProperties;

/// <summary>
/// Deleted object type.
///
/// For Message Batches, this is always `"message_batch_deleted"`.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type MessageBatchDeleted = new("message_batch_deleted");

    readonly string _value = value;

    public enum Value
    {
        MessageBatchDeleted,
    }

    public Value Known() =>
        _value switch
        {
            "message_batch_deleted" => Value.MessageBatchDeleted,
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
