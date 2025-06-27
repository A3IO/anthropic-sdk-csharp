using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages.BetaWebSearchTool20250305Properties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type WebSearch20250305 = new("web_search_20250305");

    readonly string _value = value;

    public enum Value
    {
        WebSearch20250305,
    }

    public Value Known() =>
        _value switch
        {
            "web_search_20250305" => Value.WebSearch20250305,
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
