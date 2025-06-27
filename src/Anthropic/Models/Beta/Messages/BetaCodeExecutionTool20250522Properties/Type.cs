using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages.BetaCodeExecutionTool20250522Properties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type CodeExecution20250522 = new("code_execution_20250522");

    readonly string _value = value;

    public enum Value
    {
        CodeExecution20250522,
    }

    public Value Known() =>
        _value switch
        {
            "code_execution_20250522" => Value.CodeExecution20250522,
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
