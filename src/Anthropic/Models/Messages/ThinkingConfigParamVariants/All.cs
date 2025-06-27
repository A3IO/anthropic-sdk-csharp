using Anthropic = Anthropic;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.ThinkingConfigParamVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<ThinkingConfigEnabled, Messages::ThinkingConfigEnabled>)
)]
public sealed record class ThinkingConfigEnabled(Messages::ThinkingConfigEnabled Value)
    : Messages::ThinkingConfigParam,
        Anthropic::IVariant<ThinkingConfigEnabled, Messages::ThinkingConfigEnabled>
{
    public static ThinkingConfigEnabled From(Messages::ThinkingConfigEnabled value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<ThinkingConfigDisabled, Messages::ThinkingConfigDisabled>)
)]
public sealed record class ThinkingConfigDisabled(Messages::ThinkingConfigDisabled Value)
    : Messages::ThinkingConfigParam,
        Anthropic::IVariant<ThinkingConfigDisabled, Messages::ThinkingConfigDisabled>
{
    public static ThinkingConfigDisabled From(Messages::ThinkingConfigDisabled value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
