using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages.BetaCodeExecutionResultBlockProperties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type CodeExecutionResult = new("code_execution_result");

    readonly string _value = value;

    public enum Value
    {
        CodeExecutionResult,
    }

    public Value Known() =>
        _value switch
        {
            "code_execution_result" => Value.CodeExecutionResult,
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
