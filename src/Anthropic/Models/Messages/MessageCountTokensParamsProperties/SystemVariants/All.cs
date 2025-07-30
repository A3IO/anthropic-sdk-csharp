using Anthropic = Anthropic;
using Generic = System.Collections.Generic;
using MessageCountTokensParamsProperties = Anthropic.Models.Messages.MessageCountTokensParamsProperties;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.MessageCountTokensParamsProperties.SystemVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<String, string>))]
public sealed record class String(string Value)
    : MessageCountTokensParamsProperties::System,
        Anthropic::IVariant<String, string>
{
    public static String From(string value)
    {
        return new(value);
    }

    public override void Validate() { }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<TextBlockParams, Generic::List<Messages::TextBlockParam>>)
)]
public sealed record class TextBlockParams(Generic::List<Messages::TextBlockParam> Value)
    : MessageCountTokensParamsProperties::System,
        Anthropic::IVariant<TextBlockParams, Generic::List<Messages::TextBlockParam>>
{
    public static TextBlockParams From(Generic::List<Messages::TextBlockParam> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
