using Anthropic = Anthropic;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.RawContentBlockDeltaVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<TextDelta, Messages::TextDelta>))]
public sealed record class TextDelta(Messages::TextDelta Value)
    : Messages::RawContentBlockDelta,
        Anthropic::IVariant<TextDelta, Messages::TextDelta>
{
    public static TextDelta From(Messages::TextDelta value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<InputJSONDelta, Messages::InputJSONDelta>)
)]
public sealed record class InputJSONDelta(Messages::InputJSONDelta Value)
    : Messages::RawContentBlockDelta,
        Anthropic::IVariant<InputJSONDelta, Messages::InputJSONDelta>
{
    public static InputJSONDelta From(Messages::InputJSONDelta value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<CitationsDelta, Messages::CitationsDelta>)
)]
public sealed record class CitationsDelta(Messages::CitationsDelta Value)
    : Messages::RawContentBlockDelta,
        Anthropic::IVariant<CitationsDelta, Messages::CitationsDelta>
{
    public static CitationsDelta From(Messages::CitationsDelta value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<ThinkingDelta, Messages::ThinkingDelta>)
)]
public sealed record class ThinkingDelta(Messages::ThinkingDelta Value)
    : Messages::RawContentBlockDelta,
        Anthropic::IVariant<ThinkingDelta, Messages::ThinkingDelta>
{
    public static ThinkingDelta From(Messages::ThinkingDelta value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<SignatureDelta, Messages::SignatureDelta>)
)]
public sealed record class SignatureDelta(Messages::SignatureDelta Value)
    : Messages::RawContentBlockDelta,
        Anthropic::IVariant<SignatureDelta, Messages::SignatureDelta>
{
    public static SignatureDelta From(Messages::SignatureDelta value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
