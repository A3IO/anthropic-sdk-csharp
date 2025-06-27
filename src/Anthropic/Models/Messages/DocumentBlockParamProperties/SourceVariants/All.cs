using Anthropic = Anthropic;
using DocumentBlockParamProperties = Anthropic.Models.Messages.DocumentBlockParamProperties;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.DocumentBlockParamProperties.SourceVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<Base64PDFSource, Messages::Base64PDFSource>)
)]
public sealed record class Base64PDFSource(Messages::Base64PDFSource Value)
    : DocumentBlockParamProperties::Source,
        Anthropic::IVariant<Base64PDFSource, Messages::Base64PDFSource>
{
    public static Base64PDFSource From(Messages::Base64PDFSource value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<PlainTextSource, Messages::PlainTextSource>)
)]
public sealed record class PlainTextSource(Messages::PlainTextSource Value)
    : DocumentBlockParamProperties::Source,
        Anthropic::IVariant<PlainTextSource, Messages::PlainTextSource>
{
    public static PlainTextSource From(Messages::PlainTextSource value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<ContentBlockSource, Messages::ContentBlockSource>)
)]
public sealed record class ContentBlockSource(Messages::ContentBlockSource Value)
    : DocumentBlockParamProperties::Source,
        Anthropic::IVariant<ContentBlockSource, Messages::ContentBlockSource>
{
    public static ContentBlockSource From(Messages::ContentBlockSource value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<URLPDFSource, Messages::URLPDFSource>)
)]
public sealed record class URLPDFSource(Messages::URLPDFSource Value)
    : DocumentBlockParamProperties::Source,
        Anthropic::IVariant<URLPDFSource, Messages::URLPDFSource>
{
    public static URLPDFSource From(Messages::URLPDFSource value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
