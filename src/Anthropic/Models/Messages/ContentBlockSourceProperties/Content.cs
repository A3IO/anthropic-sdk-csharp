using Anthropic = Anthropic;
using ContentVariants = Anthropic.Models.Messages.ContentBlockSourceProperties.ContentVariants;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.ContentBlockSourceProperties;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<Content>))]
public abstract record class Content
{
    internal Content() { }

    public static ContentVariants::UnionMember0 Create(string value) => new(value);

    public static ContentVariants::ContentBlockSourceContent Create(
        Generic::List<Messages::ContentBlockSourceContent> value
    ) => new(value);

    public abstract void Validate();
}
