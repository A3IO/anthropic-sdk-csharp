using Anthropic = Anthropic;
using BetaImageBlockParamProperties = Anthropic.Models.Beta.Messages.BetaImageBlockParamProperties;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaImageBlockParamProperties.SourceVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaBase64ImageSource, Messages::BetaBase64ImageSource>)
)]
public sealed record class BetaBase64ImageSource(Messages::BetaBase64ImageSource Value)
    : BetaImageBlockParamProperties::Source,
        Anthropic::IVariant<BetaBase64ImageSource, Messages::BetaBase64ImageSource>
{
    public static BetaBase64ImageSource From(Messages::BetaBase64ImageSource value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaURLImageSource, Messages::BetaURLImageSource>)
)]
public sealed record class BetaURLImageSource(Messages::BetaURLImageSource Value)
    : BetaImageBlockParamProperties::Source,
        Anthropic::IVariant<BetaURLImageSource, Messages::BetaURLImageSource>
{
    public static BetaURLImageSource From(Messages::BetaURLImageSource value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaFileImageSource, Messages::BetaFileImageSource>)
)]
public sealed record class BetaFileImageSource(Messages::BetaFileImageSource Value)
    : BetaImageBlockParamProperties::Source,
        Anthropic::IVariant<BetaFileImageSource, Messages::BetaFileImageSource>
{
    public static BetaFileImageSource From(Messages::BetaFileImageSource value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
