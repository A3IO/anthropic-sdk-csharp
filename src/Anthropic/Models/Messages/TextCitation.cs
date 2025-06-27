using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using TextCitationVariants = Anthropic.Models.Messages.TextCitationVariants;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<TextCitation>))]
public abstract record class TextCitation
{
    internal TextCitation() { }

    public static TextCitationVariants::CitationCharLocation Create(CitationCharLocation value) =>
        new(value);

    public static TextCitationVariants::CitationPageLocation Create(CitationPageLocation value) =>
        new(value);

    public static TextCitationVariants::CitationContentBlockLocation Create(
        CitationContentBlockLocation value
    ) => new(value);

    public static TextCitationVariants::CitationsWebSearchResultLocation Create(
        CitationsWebSearchResultLocation value
    ) => new(value);

    public abstract void Validate();
}
