using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.BetaGatewayTimeoutErrorProperties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type TimeoutError = new("timeout_error");

    readonly string _value = value;

    public enum Value
    {
        TimeoutError,
    }

    public Value Known() =>
        _value switch
        {
            "timeout_error" => Value.TimeoutError,
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
