using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages.BetaToolComputerUse20241022Properties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type Computer20241022 = new("computer_20241022");

    readonly string _value = value;

    public enum Value
    {
        Computer20241022,
    }

    public Value Known() =>
        _value switch
        {
            "computer_20241022" => Value.Computer20241022,
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
