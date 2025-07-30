using Anthropic = Anthropic;
using Generic = System.Collections.Generic;
using MessageCreateParamsProperties = Anthropic.Models.Messages.MessageCreateParamsProperties;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.MessageCreateParamsProperties.SystemVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<String, string>))]
public sealed record class String(string Value)
    : MessageCreateParamsProperties::System,
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
    : MessageCreateParamsProperties::System,
        Anthropic::IVariant<TextBlockParams, Generic::List<Messages::TextBlockParam>>
{
    public static TextBlockParams From(Generic::List<Messages::TextBlockParam> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
