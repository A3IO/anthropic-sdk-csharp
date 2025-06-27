using Anthropic = Anthropic;
using ImageBlockParamProperties = Anthropic.Models.Messages.ImageBlockParamProperties;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.ImageBlockParamProperties.SourceVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<Base64ImageSource, Messages::Base64ImageSource>)
)]
public sealed record class Base64ImageSource(Messages::Base64ImageSource Value)
    : ImageBlockParamProperties::Source,
        Anthropic::IVariant<Base64ImageSource, Messages::Base64ImageSource>
{
    public static Base64ImageSource From(Messages::Base64ImageSource value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<URLImageSource, Messages::URLImageSource>)
)]
public sealed record class URLImageSource(Messages::URLImageSource Value)
    : ImageBlockParamProperties::Source,
        Anthropic::IVariant<URLImageSource, Messages::URLImageSource>
{
    public static URLImageSource From(Messages::URLImageSource value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
