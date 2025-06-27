using Anthropic = Anthropic;
using ContentBlockSourceContentVariants = Anthropic.Models.Messages.ContentBlockSourceContentVariants;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<ContentBlockSourceContent>))]
public abstract record class ContentBlockSourceContent
{
    internal ContentBlockSourceContent() { }

    public static ContentBlockSourceContentVariants::TextBlockParam Create(TextBlockParam value) =>
        new(value);

    public static ContentBlockSourceContentVariants::ImageBlockParam Create(
        ImageBlockParam value
    ) => new(value);

    public abstract void Validate();
}
