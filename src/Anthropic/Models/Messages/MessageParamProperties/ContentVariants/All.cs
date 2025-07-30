using Anthropic = Anthropic;
using Generic = System.Collections.Generic;
using MessageParamProperties = Anthropic.Models.Messages.MessageParamProperties;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.MessageParamProperties.ContentVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<String, string>))]
public sealed record class String(string Value)
    : MessageParamProperties::Content,
        Anthropic::IVariant<String, string>
{
    public static String From(string value)
    {
        return new(value);
    }

    public override void Validate() { }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        ContentBlockParams,
        Generic::List<Messages::ContentBlockParam>
    >)
)]
public sealed record class ContentBlockParams(Generic::List<Messages::ContentBlockParam> Value)
    : MessageParamProperties::Content,
        Anthropic::IVariant<ContentBlockParams, Generic::List<Messages::ContentBlockParam>>
{
    public static ContentBlockParams From(Generic::List<Messages::ContentBlockParam> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
