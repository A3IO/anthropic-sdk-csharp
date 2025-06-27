using Anthropic = Anthropic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaRawContentBlockDeltaVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaTextDelta, Messages::BetaTextDelta>)
)]
public sealed record class BetaTextDelta(Messages::BetaTextDelta Value)
    : Messages::BetaRawContentBlockDelta,
        Anthropic::IVariant<BetaTextDelta, Messages::BetaTextDelta>
{
    public static BetaTextDelta From(Messages::BetaTextDelta value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaInputJSONDelta, Messages::BetaInputJSONDelta>)
)]
public sealed record class BetaInputJSONDelta(Messages::BetaInputJSONDelta Value)
    : Messages::BetaRawContentBlockDelta,
        Anthropic::IVariant<BetaInputJSONDelta, Messages::BetaInputJSONDelta>
{
    public static BetaInputJSONDelta From(Messages::BetaInputJSONDelta value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaCitationsDelta, Messages::BetaCitationsDelta>)
)]
public sealed record class BetaCitationsDelta(Messages::BetaCitationsDelta Value)
    : Messages::BetaRawContentBlockDelta,
        Anthropic::IVariant<BetaCitationsDelta, Messages::BetaCitationsDelta>
{
    public static BetaCitationsDelta From(Messages::BetaCitationsDelta value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaThinkingDelta, Messages::BetaThinkingDelta>)
)]
public sealed record class BetaThinkingDelta(Messages::BetaThinkingDelta Value)
    : Messages::BetaRawContentBlockDelta,
        Anthropic::IVariant<BetaThinkingDelta, Messages::BetaThinkingDelta>
{
    public static BetaThinkingDelta From(Messages::BetaThinkingDelta value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaSignatureDelta, Messages::BetaSignatureDelta>)
)]
public sealed record class BetaSignatureDelta(Messages::BetaSignatureDelta Value)
    : Messages::BetaRawContentBlockDelta,
        Anthropic::IVariant<BetaSignatureDelta, Messages::BetaSignatureDelta>
{
    public static BetaSignatureDelta From(Messages::BetaSignatureDelta value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
