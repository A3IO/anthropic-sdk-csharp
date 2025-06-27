using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages.WebSearchToolResultBlockProperties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type WebSearchToolResult = new("web_search_tool_result");

    readonly string _value = value;

    public enum Value
    {
        WebSearchToolResult,
    }

    public Value Known() =>
        _value switch
        {
            "web_search_tool_result" => Value.WebSearchToolResult,
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
