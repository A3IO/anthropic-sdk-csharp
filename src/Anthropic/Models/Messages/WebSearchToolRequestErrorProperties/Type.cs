using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages.WebSearchToolRequestErrorProperties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type WebSearchToolResultError = new("web_search_tool_result_error");

    readonly string _value = value;

    public enum Value
    {
        WebSearchToolResultError,
    }

    public Value Known() =>
        _value switch
        {
            "web_search_tool_result_error" => Value.WebSearchToolResultError,
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
