using Anthropic = Anthropic;
using RawContentBlockDeltaVariants = Anthropic.Models.Messages.RawContentBlockDeltaVariants;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<RawContentBlockDelta>))]
public abstract record class RawContentBlockDelta
{
    internal RawContentBlockDelta() { }

    public static RawContentBlockDeltaVariants::TextDelta Create(TextDelta value) => new(value);

    public static RawContentBlockDeltaVariants::InputJSONDelta Create(InputJSONDelta value) =>
        new(value);

    public static RawContentBlockDeltaVariants::CitationsDelta Create(CitationsDelta value) =>
        new(value);

    public static RawContentBlockDeltaVariants::ThinkingDelta Create(ThinkingDelta value) =>
        new(value);

    public static RawContentBlockDeltaVariants::SignatureDelta Create(SignatureDelta value) =>
        new(value);

    public abstract void Validate();
}
