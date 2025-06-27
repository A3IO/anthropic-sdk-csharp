using Anthropic = Anthropic;
using ContentProperties = Anthropic.Models.Messages.ToolResultBlockParamProperties.ContentProperties;
using Generic = System.Collections.Generic;
using Serialization = System.Text.Json.Serialization;
using ToolResultBlockParamProperties = Anthropic.Models.Messages.ToolResultBlockParamProperties;

namespace Anthropic.Models.Messages.ToolResultBlockParamProperties.ContentVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<UnionMember0, string>))]
public sealed record class UnionMember0(string Value)
    : ToolResultBlockParamProperties::Content,
        Anthropic::IVariant<UnionMember0, string>
{
    public static UnionMember0 From(string value)
    {
        return new(value);
    }

    public override void Validate() { }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<UnionMember1, Generic::List<ContentProperties::Block>>)
)]
public sealed record class UnionMember1(Generic::List<ContentProperties::Block> Value)
    : ToolResultBlockParamProperties::Content,
        Anthropic::IVariant<UnionMember1, Generic::List<ContentProperties::Block>>
{
    public static UnionMember1 From(Generic::List<ContentProperties::Block> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
