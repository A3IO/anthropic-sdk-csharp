using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages.RawContentBlockDeltaEventProperties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type ContentBlockDelta = new("content_block_delta");

    readonly string _value = value;

    public enum Value
    {
        ContentBlockDelta,
    }

    public Value Known() =>
        _value switch
        {
            "content_block_delta" => Value.ContentBlockDelta,
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
