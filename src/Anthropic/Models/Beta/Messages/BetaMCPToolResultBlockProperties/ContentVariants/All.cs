using Anthropic = Anthropic;
using BetaMCPToolResultBlockProperties = Anthropic.Models.Beta.Messages.BetaMCPToolResultBlockProperties;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaMCPToolResultBlockProperties.ContentVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<String, string>))]
public sealed record class String(string Value)
    : BetaMCPToolResultBlockProperties::Content,
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
        BetaMCPToolResultBlockContent,
        Generic::List<Messages::BetaTextBlock>
    >)
)]
public sealed record class BetaMCPToolResultBlockContent(
    Generic::List<Messages::BetaTextBlock> Value
)
    : BetaMCPToolResultBlockProperties::Content,
        Anthropic::IVariant<BetaMCPToolResultBlockContent, Generic::List<Messages::BetaTextBlock>>
{
    public static BetaMCPToolResultBlockContent From(Generic::List<Messages::BetaTextBlock> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
