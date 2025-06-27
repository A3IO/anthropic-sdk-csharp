using Anthropic = Anthropic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaContentBlockSourceContentVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaTextBlockParam, Messages::BetaTextBlockParam>)
)]
public sealed record class BetaTextBlockParam(Messages::BetaTextBlockParam Value)
    : Messages::BetaContentBlockSourceContent,
        Anthropic::IVariant<BetaTextBlockParam, Messages::BetaTextBlockParam>
{
    public static BetaTextBlockParam From(Messages::BetaTextBlockParam value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaImageBlockParam, Messages::BetaImageBlockParam>)
)]
public sealed record class BetaImageBlockParam(Messages::BetaImageBlockParam Value)
    : Messages::BetaContentBlockSourceContent,
        Anthropic::IVariant<BetaImageBlockParam, Messages::BetaImageBlockParam>
{
    public static BetaImageBlockParam From(Messages::BetaImageBlockParam value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
