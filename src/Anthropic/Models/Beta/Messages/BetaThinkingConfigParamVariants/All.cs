using Anthropic = Anthropic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaThinkingConfigParamVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaThinkingConfigEnabled,
        Messages::BetaThinkingConfigEnabled
    >)
)]
public sealed record class BetaThinkingConfigEnabled(Messages::BetaThinkingConfigEnabled Value)
    : Messages::BetaThinkingConfigParam,
        Anthropic::IVariant<BetaThinkingConfigEnabled, Messages::BetaThinkingConfigEnabled>
{
    public static BetaThinkingConfigEnabled From(Messages::BetaThinkingConfigEnabled value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaThinkingConfigDisabled,
        Messages::BetaThinkingConfigDisabled
    >)
)]
public sealed record class BetaThinkingConfigDisabled(Messages::BetaThinkingConfigDisabled Value)
    : Messages::BetaThinkingConfigParam,
        Anthropic::IVariant<BetaThinkingConfigDisabled, Messages::BetaThinkingConfigDisabled>
{
    public static BetaThinkingConfigDisabled From(Messages::BetaThinkingConfigDisabled value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
