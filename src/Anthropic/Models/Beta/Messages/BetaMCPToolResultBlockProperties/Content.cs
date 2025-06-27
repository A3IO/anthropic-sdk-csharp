using Anthropic = Anthropic;
using ContentVariants = Anthropic.Models.Beta.Messages.BetaMCPToolResultBlockProperties.ContentVariants;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaMCPToolResultBlockProperties;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<Content>))]
public abstract record class Content
{
    internal Content() { }

    public static ContentVariants::UnionMember0 Create(string value) => new(value);

    public static ContentVariants::BetaMCPToolResultBlockContent Create(
        Generic::List<Messages::BetaTextBlock> value
    ) => new(value);

    public abstract void Validate();
}
