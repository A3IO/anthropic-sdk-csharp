using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages.BetaPlainTextSourceProperties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<MediaType, string>))]
public sealed record class MediaType(string value) : Anthropic::IEnum<MediaType, string>
{
    public static readonly MediaType TextPlain = new("text/plain");

    readonly string _value = value;

    public enum Value
    {
        TextPlain,
    }

    public Value Known() =>
        _value switch
        {
            "text/plain" => Value.TextPlain,
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

    public static MediaType FromRaw(string value)
    {
        return new(value);
    }
}
