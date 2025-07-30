using Anthropic = Anthropic;
using Generic = System.Collections.Generic;
using MessageCountTokensParamsProperties = Anthropic.Models.Beta.Messages.MessageCountTokensParamsProperties;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.MessageCountTokensParamsProperties.SystemVariants;

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
    typeof(Anthropic::VariantConverter<
        BetaTextBlockParams,
        Generic::List<Messages::BetaTextBlockParam>
    >)
)]
public sealed record class BetaTextBlockParams(Generic::List<Messages::BetaTextBlockParam> Value)
    : MessageCountTokensParamsProperties::System,
        Anthropic::IVariant<BetaTextBlockParams, Generic::List<Messages::BetaTextBlockParam>>
{
    public static BetaTextBlockParams From(Generic::List<Messages::BetaTextBlockParam> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
