using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Completions.CompletionProperties;

/// <summary>
/// Object type.
///
/// For Text Completions, this is always `"completion"`.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type Completion = new("completion");

    readonly string _value = value;

    public enum Value
    {
        Completion,
    }

    public Value Known() =>
        _value switch
        {
            "completion" => Value.Completion,
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
