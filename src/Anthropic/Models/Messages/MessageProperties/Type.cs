using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages.MessageProperties;

/// <summary>
/// Object type.
///
/// For Messages, this is always `"message"`.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type Message = new("message");

    readonly string _value = value;

    public enum Value
    {
        Message,
    }

    public Value Known() =>
        _value switch
        {
            "message" => Value.Message,
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
