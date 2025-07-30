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

    public static implicit operator Content(string value) => new ContentVariants::String(value);

    public static implicit operator Content(Generic::List<Messages::ContentBlockParam> value) =>
        new ContentVariants::ContentBlockParams(value);

    public abstract void Validate();
}
