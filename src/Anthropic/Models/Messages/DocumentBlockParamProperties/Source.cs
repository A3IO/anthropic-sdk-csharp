using Anthropic = Anthropic;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;
using SourceVariants = Anthropic.Models.Messages.DocumentBlockParamProperties.SourceVariants;

namespace Anthropic.Models.Messages.DocumentBlockParamProperties;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<Source>))]
public abstract record class Source
{
    internal Source() { }

    public static SourceVariants::Base64PDFSource Create(Messages::Base64PDFSource value) =>
        new(value);

    public static SourceVariants::PlainTextSource Create(Messages::PlainTextSource value) =>
        new(value);

    public static SourceVariants::ContentBlockSource Create(Messages::ContentBlockSource value) =>
        new(value);

    public static SourceVariants::URLPDFSource Create(Messages::URLPDFSource value) => new(value);

    public abstract void Validate();
}
