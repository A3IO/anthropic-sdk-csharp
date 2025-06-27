using Anthropic = Anthropic;
using BetaRawContentBlockDeltaVariants = Anthropic.Models.Beta.Messages.BetaRawContentBlockDeltaVariants;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<BetaRawContentBlockDelta>))]
public abstract record class BetaRawContentBlockDelta
{
    internal BetaRawContentBlockDelta() { }

    public static BetaRawContentBlockDeltaVariants::BetaTextDelta Create(BetaTextDelta value) =>
        new(value);

    public static BetaRawContentBlockDeltaVariants::BetaInputJSONDelta Create(
        BetaInputJSONDelta value
    ) => new(value);

    public static BetaRawContentBlockDeltaVariants::BetaCitationsDelta Create(
        BetaCitationsDelta value
    ) => new(value);

    public static BetaRawContentBlockDeltaVariants::BetaThinkingDelta Create(
        BetaThinkingDelta value
    ) => new(value);

    public static BetaRawContentBlockDeltaVariants::BetaSignatureDelta Create(
        BetaSignatureDelta value
    ) => new(value);

    public abstract void Validate();
}
