using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages.BetaToolBash20241022Properties;

/// <summary>
/// Name of the tool.
///
/// This is how the tool will be called by the model and in `tool_use` blocks.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Name, string>))]
public sealed record class Name(string value) : Anthropic::IEnum<Name, string>
{
    public static readonly Name Bash = new("bash");

    readonly string _value = value;

    public enum Value
    {
        Bash,
    }

    public Value Known() =>
        _value switch
        {
            "bash" => Value.Bash,
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
