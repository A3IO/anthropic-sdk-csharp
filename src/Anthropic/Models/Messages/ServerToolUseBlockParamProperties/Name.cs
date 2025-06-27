using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages.ServerToolUseBlockParamProperties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Name, string>))]
public sealed record class Name(string value) : Anthropic::IEnum<Name, string>
{
    public static readonly Name WebSearch = new("web_search");

    readonly string _value = value;

    public enum Value
    {
        WebSearch,
    }

    public Value Known() =>
        _value switch
        {
            "web_search" => Value.WebSearch,
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

    public static Name FromRaw(string value)
    {
        return new(value);
    }
}
