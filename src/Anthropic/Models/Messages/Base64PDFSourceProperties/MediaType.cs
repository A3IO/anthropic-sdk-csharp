using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages.Base64PDFSourceProperties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<MediaType, string>))]
public sealed record class MediaType(string value) : Anthropic::IEnum<MediaType, string>
{
    public static readonly MediaType ApplicationPDF = new("application/pdf");

    readonly string _value = value;

    public enum Value
    {
        ApplicationPDF,
    }

    public Value Known() =>
        _value switch
        {
            "application/pdf" => Value.ApplicationPDF,
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
