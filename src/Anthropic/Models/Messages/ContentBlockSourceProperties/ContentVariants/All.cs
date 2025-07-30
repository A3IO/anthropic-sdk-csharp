using Anthropic = Anthropic;
using ContentBlockSourceProperties = Anthropic.Models.Messages.ContentBlockSourceProperties;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.ContentBlockSourceProperties.ContentVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<String, string>))]
public sealed record class String(string Value)
    : ContentBlockSourceProperties::Content,
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
        ContentBlockSourceContent,
        Generic::List<Messages::ContentBlockSourceContent>
    >)
)]
public sealed record class ContentBlockSourceContent(
    Generic::List<Messages::ContentBlockSourceContent> Value
)
    : ContentBlockSourceProperties::Content,
        Anthropic::IVariant<
            ContentBlockSourceContent,
            Generic::List<Messages::ContentBlockSourceContent>
        >
{
    public static ContentBlockSourceContent From(
        Generic::List<Messages::ContentBlockSourceContent> value
    )
    {
        return new(value);
    }

    public override void Validate() { }
}
