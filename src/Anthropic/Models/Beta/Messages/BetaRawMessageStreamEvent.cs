using Anthropic = Anthropic;
using BetaRawMessageStreamEventVariants = Anthropic.Models.Beta.Messages.BetaRawMessageStreamEventVariants;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<BetaRawMessageStreamEvent>))]
public abstract record class BetaRawMessageStreamEvent
{
    internal BetaRawMessageStreamEvent() { }

    public static BetaRawMessageStreamEventVariants::BetaRawMessageStartEvent Create(
        BetaRawMessageStartEvent value
    ) => new(value);

    public static BetaRawMessageStreamEventVariants::BetaRawMessageDeltaEvent Create(
        BetaRawMessageDeltaEvent value
    ) => new(value);

    public static BetaRawMessageStreamEventVariants::BetaRawMessageStopEvent Create(
        BetaRawMessageStopEvent value
    ) => new(value);

    public static BetaRawMessageStreamEventVariants::BetaRawContentBlockStartEvent Create(
        BetaRawContentBlockStartEvent value
    ) => new(value);

    public static BetaRawMessageStreamEventVariants::BetaRawContentBlockDeltaEvent Create(
        BetaRawContentBlockDeltaEvent value
    ) => new(value);

    public static BetaRawMessageStreamEventVariants::BetaRawContentBlockStopEvent Create(
        BetaRawContentBlockStopEvent value
    ) => new(value);

    public abstract void Validate();
}
