using Anthropic = Anthropic;
using BetaMessageParamProperties = Anthropic.Models.Beta.Messages.BetaMessageParamProperties;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaMessageParamProperties.ContentVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<String, string>))]
public sealed record class String(string Value)
    : BetaMessageParamProperties::Content,
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
        BetaContentBlockParams,
        Generic::List<Messages::BetaContentBlockParam>
    >)
)]
public sealed record class BetaContentBlockParams(
    Generic::List<Messages::BetaContentBlockParam> Value
)
    : BetaMessageParamProperties::Content,
        Anthropic::IVariant<BetaContentBlockParams, Generic::List<Messages::BetaContentBlockParam>>
{
    public static BetaContentBlockParams From(Generic::List<Messages::BetaContentBlockParam> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
