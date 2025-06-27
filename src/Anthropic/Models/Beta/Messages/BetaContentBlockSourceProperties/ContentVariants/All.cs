using Anthropic = Anthropic;
using BetaContentBlockSourceProperties = Anthropic.Models.Beta.Messages.BetaContentBlockSourceProperties;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaContentBlockSourceProperties.ContentVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<UnionMember0, string>))]
public sealed record class UnionMember0(string Value)
    : BetaContentBlockSourceProperties::Content,
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
        BetaContentBlockSourceContent,
        Generic::List<Messages::BetaContentBlockSourceContent>
    >)
)]
public sealed record class BetaContentBlockSourceContent(
    Generic::List<Messages::BetaContentBlockSourceContent> Value
)
    : BetaContentBlockSourceProperties::Content,
        Anthropic::IVariant<
            BetaContentBlockSourceContent,
            Generic::List<Messages::BetaContentBlockSourceContent>
        >
{
    public static BetaContentBlockSourceContent From(
        Generic::List<Messages::BetaContentBlockSourceContent> value
    )
    {
        return new(value);
    }

    public override void Validate() { }
}
