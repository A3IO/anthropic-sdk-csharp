using Anthropic = Anthropic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaToolChoiceVariants;

/// <summary>
/// The model will automatically decide whether to use tools.
/// </summary>
[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaToolChoiceAuto, Messages::BetaToolChoiceAuto>)
)]
public sealed record class BetaToolChoiceAuto(Messages::BetaToolChoiceAuto Value)
    : Messages::BetaToolChoice,
        Anthropic::IVariant<BetaToolChoiceAuto, Messages::BetaToolChoiceAuto>
{
    public static BetaToolChoiceAuto From(Messages::BetaToolChoiceAuto value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

/// <summary>
/// The model will use any available tools.
/// </summary>
[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaToolChoiceAny, Messages::BetaToolChoiceAny>)
)]
public sealed record class BetaToolChoiceAny(Messages::BetaToolChoiceAny Value)
    : Messages::BetaToolChoice,
        Anthropic::IVariant<BetaToolChoiceAny, Messages::BetaToolChoiceAny>
{
    public static BetaToolChoiceAny From(Messages::BetaToolChoiceAny value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

/// <summary>
/// The model will use the specified tool with `tool_choice.name`.
/// </summary>
[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaToolChoiceTool, Messages::BetaToolChoiceTool>)
)]
public sealed record class BetaToolChoiceTool(Messages::BetaToolChoiceTool Value)
    : Messages::BetaToolChoice,
        Anthropic::IVariant<BetaToolChoiceTool, Messages::BetaToolChoiceTool>
{
    public static BetaToolChoiceTool From(Messages::BetaToolChoiceTool value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

/// <summary>
/// The model will not be allowed to use tools.
/// </summary>
[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaToolChoiceNone, Messages::BetaToolChoiceNone>)
)]
public sealed record class BetaToolChoiceNone(Messages::BetaToolChoiceNone Value)
    : Messages::BetaToolChoice,
        Anthropic::IVariant<BetaToolChoiceNone, Messages::BetaToolChoiceNone>
{
    public static BetaToolChoiceNone From(Messages::BetaToolChoiceNone value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
