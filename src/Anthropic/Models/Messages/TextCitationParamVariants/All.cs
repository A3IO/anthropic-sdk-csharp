using Anthropic = Anthropic;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.TextCitationParamVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        CitationCharLocationParam,
        Messages::CitationCharLocationParam
    >)
)]
public sealed record class CitationCharLocationParam(Messages::CitationCharLocationParam Value)
    : Messages::TextCitationParam,
        Anthropic::IVariant<CitationCharLocationParam, Messages::CitationCharLocationParam>
{
    public static CitationCharLocationParam From(Messages::CitationCharLocationParam value)
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
        CitationPageLocationParam,
        Messages::CitationPageLocationParam
    >)
)]
public sealed record class CitationPageLocationParam(Messages::CitationPageLocationParam Value)
    : Messages::TextCitationParam,
        Anthropic::IVariant<CitationPageLocationParam, Messages::CitationPageLocationParam>
{
    public static CitationPageLocationParam From(Messages::CitationPageLocationParam value)
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
        CitationContentBlockLocationParam,
        Messages::CitationContentBlockLocationParam
    >)
)]
public sealed record class CitationContentBlockLocationParam(
    Messages::CitationContentBlockLocationParam Value
)
    : Messages::TextCitationParam,
        Anthropic::IVariant<
            CitationContentBlockLocationParam,
            Messages::CitationContentBlockLocationParam
        >
{
    public static CitationContentBlockLocationParam From(
        Messages::CitationContentBlockLocationParam value
    )
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
        CitationWebSearchResultLocationParam,
        Messages::CitationWebSearchResultLocationParam
    >)
)]
public sealed record class CitationWebSearchResultLocationParam(
    Messages::CitationWebSearchResultLocationParam Value
)
    : Messages::TextCitationParam,
        Anthropic::IVariant<
            CitationWebSearchResultLocationParam,
            Messages::CitationWebSearchResultLocationParam
        >
{
    public static CitationWebSearchResultLocationParam From(
        Messages::CitationWebSearchResultLocationParam value
    )
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
