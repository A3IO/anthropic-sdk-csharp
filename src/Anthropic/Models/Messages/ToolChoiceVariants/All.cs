using Anthropic = Anthropic;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.ToolChoiceVariants;

/// <summary>
/// The model will automatically decide whether to use tools.
/// </summary>
[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<ToolChoiceAuto, Messages::ToolChoiceAuto>)
)]
public sealed record class ToolChoiceAuto(Messages::ToolChoiceAuto Value)
    : Messages::ToolChoice,
        Anthropic::IVariant<ToolChoiceAuto, Messages::ToolChoiceAuto>
{
    public static ToolChoiceAuto From(Messages::ToolChoiceAuto value)
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
    typeof(Anthropic::VariantConverter<ToolChoiceAny, Messages::ToolChoiceAny>)
)]
public sealed record class ToolChoiceAny(Messages::ToolChoiceAny Value)
    : Messages::ToolChoice,
        Anthropic::IVariant<ToolChoiceAny, Messages::ToolChoiceAny>
{
    public static ToolChoiceAny From(Messages::ToolChoiceAny value)
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
    typeof(Anthropic::VariantConverter<ToolChoiceTool, Messages::ToolChoiceTool>)
)]
public sealed record class ToolChoiceTool(Messages::ToolChoiceTool Value)
    : Messages::ToolChoice,
        Anthropic::IVariant<ToolChoiceTool, Messages::ToolChoiceTool>
{
    public static ToolChoiceTool From(Messages::ToolChoiceTool value)
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
    typeof(Anthropic::VariantConverter<ToolChoiceNone, Messages::ToolChoiceNone>)
)]
public sealed record class ToolChoiceNone(Messages::ToolChoiceNone Value)
    : Messages::ToolChoice,
        Anthropic::IVariant<ToolChoiceNone, Messages::ToolChoiceNone>
{
    public static ToolChoiceNone From(Messages::ToolChoiceNone value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
