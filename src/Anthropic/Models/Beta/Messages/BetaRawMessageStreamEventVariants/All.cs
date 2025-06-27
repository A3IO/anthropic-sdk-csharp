using Anthropic = Anthropic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaRawMessageStreamEventVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaRawMessageStartEvent,
        Messages::BetaRawMessageStartEvent
    >)
)]
public sealed record class BetaRawMessageStartEvent(Messages::BetaRawMessageStartEvent Value)
    : Messages::BetaRawMessageStreamEvent,
        Anthropic::IVariant<BetaRawMessageStartEvent, Messages::BetaRawMessageStartEvent>
{
    public static BetaRawMessageStartEvent From(Messages::BetaRawMessageStartEvent value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaRawMessageDeltaEvent,
        Messages::BetaRawMessageDeltaEvent
    >)
)]
public sealed record class BetaRawMessageDeltaEvent(Messages::BetaRawMessageDeltaEvent Value)
    : Messages::BetaRawMessageStreamEvent,
        Anthropic::IVariant<BetaRawMessageDeltaEvent, Messages::BetaRawMessageDeltaEvent>
{
    public static BetaRawMessageDeltaEvent From(Messages::BetaRawMessageDeltaEvent value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaRawMessageStopEvent, Messages::BetaRawMessageStopEvent>)
)]
public sealed record class BetaRawMessageStopEvent(Messages::BetaRawMessageStopEvent Value)
    : Messages::BetaRawMessageStreamEvent,
        Anthropic::IVariant<BetaRawMessageStopEvent, Messages::BetaRawMessageStopEvent>
{
    public static BetaRawMessageStopEvent From(Messages::BetaRawMessageStopEvent value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaRawContentBlockStartEvent,
        Messages::BetaRawContentBlockStartEvent
    >)
)]
public sealed record class BetaRawContentBlockStartEvent(
    Messages::BetaRawContentBlockStartEvent Value
)
    : Messages::BetaRawMessageStreamEvent,
        Anthropic::IVariant<BetaRawContentBlockStartEvent, Messages::BetaRawContentBlockStartEvent>
{
    public static BetaRawContentBlockStartEvent From(Messages::BetaRawContentBlockStartEvent value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaRawContentBlockDeltaEvent,
        Messages::BetaRawContentBlockDeltaEvent
    >)
)]
public sealed record class BetaRawContentBlockDeltaEvent(
    Messages::BetaRawContentBlockDeltaEvent Value
)
    : Messages::BetaRawMessageStreamEvent,
        Anthropic::IVariant<BetaRawContentBlockDeltaEvent, Messages::BetaRawContentBlockDeltaEvent>
{
    public static BetaRawContentBlockDeltaEvent From(Messages::BetaRawContentBlockDeltaEvent value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaRawContentBlockStopEvent,
        Messages::BetaRawContentBlockStopEvent
    >)
)]
public sealed record class BetaRawContentBlockStopEvent(
    Messages::BetaRawContentBlockStopEvent Value
)
    : Messages::BetaRawMessageStreamEvent,
        Anthropic::IVariant<BetaRawContentBlockStopEvent, Messages::BetaRawContentBlockStopEvent>
{
    public static BetaRawContentBlockStopEvent From(Messages::BetaRawContentBlockStopEvent value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
