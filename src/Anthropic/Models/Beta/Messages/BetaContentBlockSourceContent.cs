using Anthropic = Anthropic;
using BetaContentBlockSourceContentVariants = Anthropic.Models.Beta.Messages.BetaContentBlockSourceContentVariants;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<BetaContentBlockSourceContent>))]
public abstract record class BetaContentBlockSourceContent
{
    internal BetaContentBlockSourceContent() { }

    public static BetaContentBlockSourceContentVariants::BetaTextBlockParam Create(
        BetaTextBlockParam value
    ) => new(value);

    public static BetaContentBlockSourceContentVariants::BetaImageBlockParam Create(
        BetaImageBlockParam value
    ) => new(value);

    public abstract void Validate();
}
