using Anthropic = Anthropic;
using ContentProperties = Anthropic.Models.Messages.ToolResultBlockParamProperties.ContentProperties;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.ToolResultBlockParamProperties.ContentProperties.BlockVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<TextBlockParam, Messages::TextBlockParam>)
)]
public sealed record class TextBlockParam(Messages::TextBlockParam Value)
    : ContentProperties::Block,
        Anthropic::IVariant<TextBlockParam, Messages::TextBlockParam>
{
    public static TextBlockParam From(Messages::TextBlockParam value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<ImageBlockParam, Messages::ImageBlockParam>)
)]
public sealed record class ImageBlockParam(Messages::ImageBlockParam Value)
    : ContentProperties::Block,
        Anthropic::IVariant<ImageBlockParam, Messages::ImageBlockParam>
{
    public static ImageBlockParam From(Messages::ImageBlockParam value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
