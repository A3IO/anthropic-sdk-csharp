using Anthropic = Anthropic;
using RawMessageStreamEventVariants = Anthropic.Models.Messages.RawMessageStreamEventVariants;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<RawMessageStreamEvent>))]
public abstract record class RawMessageStreamEvent
{
    internal RawMessageStreamEvent() { }

    public static RawMessageStreamEventVariants::RawMessageStartEvent Create(
        RawMessageStartEvent value
    ) => new(value);

    public static RawMessageStreamEventVariants::RawMessageDeltaEvent Create(
        RawMessageDeltaEvent value
    ) => new(value);

    public static RawMessageStreamEventVariants::RawMessageStopEvent Create(
        RawMessageStopEvent value
    ) => new(value);

    public static RawMessageStreamEventVariants::RawContentBlockStartEvent Create(
        RawContentBlockStartEvent value
    ) => new(value);

    public static RawMessageStreamEventVariants::RawContentBlockDeltaEvent Create(
        RawContentBlockDeltaEvent value
    ) => new(value);

    public static RawMessageStreamEventVariants::RawContentBlockStopEvent Create(
        RawContentBlockStopEvent value
    ) => new(value);

    public abstract void Validate();
}
