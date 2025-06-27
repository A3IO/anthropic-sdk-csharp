using Anthropic = Anthropic;
using BetaRequestMCPToolResultBlockParamProperties = Anthropic.Models.Beta.Messages.BetaRequestMCPToolResultBlockParamProperties;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaRequestMCPToolResultBlockParamProperties.ContentVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<UnionMember0, string>))]
public sealed record class UnionMember0(string Value)
    : BetaRequestMCPToolResultBlockParamProperties::Content,
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
        BetaMCPToolResultBlockParamContent,
        Generic::List<Messages::BetaTextBlockParam>
    >)
)]
public sealed record class BetaMCPToolResultBlockParamContent(
    Generic::List<Messages::BetaTextBlockParam> Value
)
    : BetaRequestMCPToolResultBlockParamProperties::Content,
        Anthropic::IVariant<
            BetaMCPToolResultBlockParamContent,
            Generic::List<Messages::BetaTextBlockParam>
        >
{
    public static BetaMCPToolResultBlockParamContent From(
        Generic::List<Messages::BetaTextBlockParam> value
    )
    {
        return new(value);
    }

    public override void Validate() { }
}
