using Anthropic = Anthropic;
using BetaMessageParamProperties = Anthropic.Models.Beta.Messages.BetaMessageParamProperties;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaMessageParamProperties.ContentVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<UnionMember0, string>))]
public sealed record class UnionMember0(string Value)
    : BetaMessageParamProperties::Content,
        Anthropic::IVariant<UnionMember0, string>
{
    public static UnionMember0 From(string value)
    {
        return new(value);
    }

    public override void Validate() { }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        UnionMember1,
        Generic::List<Messages::BetaContentBlockParam>
    >)
)]
public sealed record class UnionMember1(Generic::List<Messages::BetaContentBlockParam> Value)
    : BetaMessageParamProperties::Content,
        Anthropic::IVariant<UnionMember1, Generic::List<Messages::BetaContentBlockParam>>
{
    public static UnionMember1 From(Generic::List<Messages::BetaContentBlockParam> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
