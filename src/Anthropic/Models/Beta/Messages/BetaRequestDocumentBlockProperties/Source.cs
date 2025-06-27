using Anthropic = Anthropic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;
using SourceVariants = Anthropic.Models.Beta.Messages.BetaRequestDocumentBlockProperties.SourceVariants;

namespace Anthropic.Models.Beta.Messages.BetaRequestDocumentBlockProperties;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<Source>))]
public abstract record class Source
{
    internal Source() { }

    public static SourceVariants::BetaBase64PDFSource Create(Messages::BetaBase64PDFSource value) =>
        new(value);

    public static SourceVariants::BetaPlainTextSource Create(Messages::BetaPlainTextSource value) =>
        new(value);

    public static SourceVariants::BetaContentBlockSource Create(
        Messages::BetaContentBlockSource value
    ) => new(value);

    public static SourceVariants::BetaURLPDFSource Create(Messages::BetaURLPDFSource value) =>
        new(value);

    public static SourceVariants::BetaFileDocumentSource Create(
        Messages::BetaFileDocumentSource value
    ) => new(value);

    public abstract void Validate();
}
