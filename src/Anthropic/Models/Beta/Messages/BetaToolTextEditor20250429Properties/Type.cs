using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages.BetaToolTextEditor20250429Properties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type TextEditor20250429 = new("text_editor_20250429");

    readonly string _value = value;

    public enum Value
    {
        TextEditor20250429,
    }

    public Value Known() =>
        _value switch
        {
            "text_editor_20250429" => Value.TextEditor20250429,
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
