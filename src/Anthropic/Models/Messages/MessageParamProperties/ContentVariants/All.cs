using Anthropic = Anthropic;
using Generic = System.Collections.Generic;
using MessageParamProperties = Anthropic.Models.Messages.MessageParamProperties;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.MessageParamProperties.ContentVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<UnionMember0, string>))]
public sealed record class UnionMember0(string Value)
    : MessageParamProperties::Content,
        Anthropic::IVariant<UnionMember0, string>
{
    public static UnionMember0 From(string value)
    {
        return new(value);
    }

    public override void Validate() { }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<UnionMember1, Generic::List<Messages::ContentBlockParam>>)
)]
public sealed record class UnionMember1(Generic::List<Messages::ContentBlockParam> Value)
    : MessageParamProperties::Content,
        Anthropic::IVariant<UnionMember1, Generic::List<Messages::ContentBlockParam>>
{
    public static UnionMember1 From(Generic::List<Messages::ContentBlockParam> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
