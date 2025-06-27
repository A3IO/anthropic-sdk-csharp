using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using TextCitationParamVariants = Anthropic.Models.Messages.TextCitationParamVariants;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<TextCitationParam>))]
public abstract record class TextCitationParam
{
    internal TextCitationParam() { }

    public static TextCitationParamVariants::CitationCharLocationParam Create(
        CitationCharLocationParam value
    ) => new(value);

    public static TextCitationParamVariants::CitationPageLocationParam Create(
        CitationPageLocationParam value
    ) => new(value);

    public static TextCitationParamVariants::CitationContentBlockLocationParam Create(
        CitationContentBlockLocationParam value
    ) => new(value);

    public static TextCitationParamVariants::CitationWebSearchResultLocationParam Create(
        CitationWebSearchResultLocationParam value
    ) => new(value);

    public abstract void Validate();
}
