using Anthropic = Anthropic;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.RawMessageStreamEventVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<RawMessageStartEvent, Messages::RawMessageStartEvent>)
)]
public sealed record class RawMessageStartEvent(Messages::RawMessageStartEvent Value)
    : Messages::RawMessageStreamEvent,
        Anthropic::IVariant<RawMessageStartEvent, Messages::RawMessageStartEvent>
{
    public static RawMessageStartEvent From(Messages::RawMessageStartEvent value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<RawMessageDeltaEvent, Messages::RawMessageDeltaEvent>)
)]
public sealed record class RawMessageDeltaEvent(Messages::RawMessageDeltaEvent Value)
    : Messages::RawMessageStreamEvent,
        Anthropic::IVariant<RawMessageDeltaEvent, Messages::RawMessageDeltaEvent>
{
    public static RawMessageDeltaEvent From(Messages::RawMessageDeltaEvent value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<RawMessageStopEvent, Messages::RawMessageStopEvent>)
)]
public sealed record class RawMessageStopEvent(Messages::RawMessageStopEvent Value)
    : Messages::RawMessageStreamEvent,
        Anthropic::IVariant<RawMessageStopEvent, Messages::RawMessageStopEvent>
{
    public static RawMessageStopEvent From(Messages::RawMessageStopEvent value)
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
        RawContentBlockStartEvent,
        Messages::RawContentBlockStartEvent
    >)
)]
public sealed record class RawContentBlockStartEvent(Messages::RawContentBlockStartEvent Value)
    : Messages::RawMessageStreamEvent,
        Anthropic::IVariant<RawContentBlockStartEvent, Messages::RawContentBlockStartEvent>
{
    public static RawContentBlockStartEvent From(Messages::RawContentBlockStartEvent value)
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
        RawContentBlockDeltaEvent,
        Messages::RawContentBlockDeltaEvent
    >)
)]
public sealed record class RawContentBlockDeltaEvent(Messages::RawContentBlockDeltaEvent Value)
    : Messages::RawMessageStreamEvent,
        Anthropic::IVariant<RawContentBlockDeltaEvent, Messages::RawContentBlockDeltaEvent>
{
    public static RawContentBlockDeltaEvent From(Messages::RawContentBlockDeltaEvent value)
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
        RawContentBlockStopEvent,
        Messages::RawContentBlockStopEvent
    >)
)]
public sealed record class RawContentBlockStopEvent(Messages::RawContentBlockStopEvent Value)
    : Messages::RawMessageStreamEvent,
        Anthropic::IVariant<RawContentBlockStopEvent, Messages::RawContentBlockStopEvent>
{
    public static RawContentBlockStopEvent From(Messages::RawContentBlockStopEvent value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
