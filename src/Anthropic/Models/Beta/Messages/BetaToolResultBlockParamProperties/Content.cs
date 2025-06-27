using Anthropic = Anthropic;
using ContentProperties = Anthropic.Models.Beta.Messages.BetaToolResultBlockParamProperties.ContentProperties;
using ContentVariants = Anthropic.Models.Beta.Messages.BetaToolResultBlockParamProperties.ContentVariants;
using Generic = System.Collections.Generic;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaToolResultBlockParamProperties;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<Content>))]
public abstract record class Content
{
    internal Content() { }

    public static ContentVariants::UnionMember0 Create(string value) => new(value);

    public static ContentVariants::UnionMember1 Create(
        Generic::List<ContentProperties::Block> value
    ) => new(value);

    public abstract void Validate();
}
