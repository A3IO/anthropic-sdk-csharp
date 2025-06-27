using Anthropic = Anthropic;
using ContentVariants = Anthropic.Models.Messages.MessageParamProperties.ContentVariants;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.MessageParamProperties;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<Content>))]
public abstract record class Content
{
    internal Content() { }

    public static ContentVariants::UnionMember0 Create(string value) => new(value);

    public static ContentVariants::UnionMember1 Create(
        Generic::List<Messages::ContentBlockParam> value
    ) => new(value);

    public abstract void Validate();
}
