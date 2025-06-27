using Anthropic = Anthropic;
using ContentVariants = Anthropic.Models.Beta.Messages.BetaRequestMCPToolResultBlockParamProperties.ContentVariants;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaRequestMCPToolResultBlockParamProperties;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<Content>))]
public abstract record class Content
{
    internal Content() { }

    public static ContentVariants::UnionMember0 Create(string value) => new(value);

    public static ContentVariants::BetaMCPToolResultBlockParamContent Create(
        Generic::List<Messages::BetaTextBlockParam> value
    ) => new(value);

    public abstract void Validate();
}
