using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Models.BetaModelInfoProperties;

/// <summary>
/// Object type.
///
/// For Models, this is always `"model"`.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type Model = new("model");

    readonly string _value = value;

    public enum Value
    {
        Model,
    }

    public Value Known() =>
        _value switch
        {
            "model" => Value.Model,
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
