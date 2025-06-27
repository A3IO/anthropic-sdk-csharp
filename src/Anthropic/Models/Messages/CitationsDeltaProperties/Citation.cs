using Anthropic = Anthropic;
using CitationVariants = Anthropic.Models.Messages.CitationsDeltaProperties.CitationVariants;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.CitationsDeltaProperties;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<Citation>))]
public abstract record class Citation
{
    internal Citation() { }

    public static CitationVariants::CitationCharLocation Create(
        Messages::CitationCharLocation value
    ) => new(value);

    public static CitationVariants::CitationPageLocation Create(
        Messages::CitationPageLocation value
    ) => new(value);

    public static CitationVariants::CitationContentBlockLocation Create(
        Messages::CitationContentBlockLocation value
    ) => new(value);

    public static CitationVariants::CitationsWebSearchResultLocation Create(
        Messages::CitationsWebSearchResultLocation value
    ) => new(value);

    public abstract void Validate();
}
