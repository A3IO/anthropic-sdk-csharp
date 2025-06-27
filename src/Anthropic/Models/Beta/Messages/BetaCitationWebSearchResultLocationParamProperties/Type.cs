using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages.BetaCitationWebSearchResultLocationParamProperties;

[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<Type, string>))]
public sealed record class Type(string value) : Anthropic::IEnum<Type, string>
{
    public static readonly Type WebSearchResultLocation = new("web_search_result_location");

    readonly string _value = value;

    public enum Value
    {
        WebSearchResultLocation,
    }

    public Value Known() =>
        _value switch
        {
            "web_search_result_location" => Value.WebSearchResultLocation,
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
