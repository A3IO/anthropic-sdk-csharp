using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages.BetaServerToolUseBlockParamProperties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Name, string>))]
public sealed record class Name(string value) : Anthropic::IEnum<Name, string>
{
    public static readonly Name WebSearch = new("web_search");

    public static readonly Name CodeExecution = new("code_execution");

    readonly string _value = value;

    public enum Value
    {
        WebSearch,
        CodeExecution,
    }

    public Value Known() =>
        _value switch
        {
            "web_search" => Value.WebSearch,
            "code_execution" => Value.CodeExecution,
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
