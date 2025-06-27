using Anthropic = Anthropic;
using Generic = System.Collections.Generic;
using MessageCountTokensParamsProperties = Anthropic.Models.Messages.MessageCountTokensParamsProperties;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.MessageCountTokensParamsProperties.SystemVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<UnionMember0, string>))]
public sealed record class UnionMember0(string Value)
    : MessageCountTokensParamsProperties::System,
        Anthropic::IVariant<UnionMember0, string>
{
    public static UnionMember0 From(string value)
    {
        return new(value);
    }

    public override void Validate() { }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<UnionMember1, Generic::List<Messages::TextBlockParam>>)
)]
public sealed record class UnionMember1(Generic::List<Messages::TextBlockParam> Value)
    : MessageCountTokensParamsProperties::System,
        Anthropic::IVariant<UnionMember1, Generic::List<Messages::TextBlockParam>>
{
    public static UnionMember1 From(Generic::List<Messages::TextBlockParam> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
