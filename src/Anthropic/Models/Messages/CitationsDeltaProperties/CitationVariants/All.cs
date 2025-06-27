using Anthropic = Anthropic;
using CitationsDeltaProperties = Anthropic.Models.Messages.CitationsDeltaProperties;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.CitationsDeltaProperties.CitationVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<CitationCharLocation, Messages::CitationCharLocation>)
)]
public sealed record class CitationCharLocation(Messages::CitationCharLocation Value)
    : CitationsDeltaProperties::Citation,
        Anthropic::IVariant<CitationCharLocation, Messages::CitationCharLocation>
{
    public static CitationCharLocation From(Messages::CitationCharLocation value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<CitationPageLocation, Messages::CitationPageLocation>)
)]
public sealed record class CitationPageLocation(Messages::CitationPageLocation Value)
    : CitationsDeltaProperties::Citation,
        Anthropic::IVariant<CitationPageLocation, Messages::CitationPageLocation>
{
    public static CitationPageLocation From(Messages::CitationPageLocation value)
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
        CitationContentBlockLocation,
        Messages::CitationContentBlockLocation
    >)
)]
public sealed record class CitationContentBlockLocation(
    Messages::CitationContentBlockLocation Value
)
    : CitationsDeltaProperties::Citation,
        Anthropic::IVariant<CitationContentBlockLocation, Messages::CitationContentBlockLocation>
{
    public static CitationContentBlockLocation From(Messages::CitationContentBlockLocation value)
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
        CitationsWebSearchResultLocation,
        Messages::CitationsWebSearchResultLocation
    >)
)]
public sealed record class CitationsWebSearchResultLocation(
    Messages::CitationsWebSearchResultLocation Value
)
    : CitationsDeltaProperties::Citation,
        Anthropic::IVariant<
            CitationsWebSearchResultLocation,
            Messages::CitationsWebSearchResultLocation
        >
{
    public static CitationsWebSearchResultLocation From(
        Messages::CitationsWebSearchResultLocation value
    )
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
