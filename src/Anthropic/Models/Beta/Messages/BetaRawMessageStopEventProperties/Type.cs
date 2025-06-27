using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages.BetaRawMessageStopEventProperties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type MessageStop = new("message_stop");

    readonly string _value = value;

    public enum Value
    {
        MessageStop,
    }

    public Value Known() =>
        _value switch
        {
            "message_stop" => Value.MessageStop,
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
