using Anthropic = Anthropic;
using BetaRequestDocumentBlockProperties = Anthropic.Models.Beta.Messages.BetaRequestDocumentBlockProperties;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaRequestDocumentBlockProperties.SourceVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaBase64PDFSource, Messages::BetaBase64PDFSource>)
)]
public sealed record class BetaBase64PDFSource(Messages::BetaBase64PDFSource Value)
    : BetaRequestDocumentBlockProperties::Source,
        Anthropic::IVariant<BetaBase64PDFSource, Messages::BetaBase64PDFSource>
{
    public static BetaBase64PDFSource From(Messages::BetaBase64PDFSource value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaPlainTextSource, Messages::BetaPlainTextSource>)
)]
public sealed record class BetaPlainTextSource(Messages::BetaPlainTextSource Value)
    : BetaRequestDocumentBlockProperties::Source,
        Anthropic::IVariant<BetaPlainTextSource, Messages::BetaPlainTextSource>
{
    public static BetaPlainTextSource From(Messages::BetaPlainTextSource value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaContentBlockSource, Messages::BetaContentBlockSource>)
)]
public sealed record class BetaContentBlockSource(Messages::BetaContentBlockSource Value)
    : BetaRequestDocumentBlockProperties::Source,
        Anthropic::IVariant<BetaContentBlockSource, Messages::BetaContentBlockSource>
{
    public static BetaContentBlockSource From(Messages::BetaContentBlockSource value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaURLPDFSource, Messages::BetaURLPDFSource>)
)]
public sealed record class BetaURLPDFSource(Messages::BetaURLPDFSource Value)
    : BetaRequestDocumentBlockProperties::Source,
        Anthropic::IVariant<BetaURLPDFSource, Messages::BetaURLPDFSource>
{
    public static BetaURLPDFSource From(Messages::BetaURLPDFSource value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaFileDocumentSource, Messages::BetaFileDocumentSource>)
)]
public sealed record class BetaFileDocumentSource(Messages::BetaFileDocumentSource Value)
    : BetaRequestDocumentBlockProperties::Source,
        Anthropic::IVariant<BetaFileDocumentSource, Messages::BetaFileDocumentSource>
{
    public static BetaFileDocumentSource From(Messages::BetaFileDocumentSource value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
