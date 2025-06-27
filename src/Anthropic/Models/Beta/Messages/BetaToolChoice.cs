using Anthropic = Anthropic;
using BetaToolChoiceVariants = Anthropic.Models.Beta.Messages.BetaToolChoiceVariants;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages;

/// <summary>
/// How the model should use the provided tools. The model can use a specific tool,
/// any available tool, decide by itself, or not use tools at all.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<BetaToolChoice>))]
public abstract record class BetaToolChoice
{
    internal BetaToolChoice() { }

    public static BetaToolChoiceVariants::BetaToolChoiceAuto Create(BetaToolChoiceAuto value) =>
        new(value);

    public static BetaToolChoiceVariants::BetaToolChoiceAny Create(BetaToolChoiceAny value) =>
        new(value);

    public static BetaToolChoiceVariants::BetaToolChoiceTool Create(BetaToolChoiceTool value) =>
        new(value);

    public static BetaToolChoiceVariants::BetaToolChoiceNone Create(BetaToolChoiceNone value) =>
        new(value);

    public abstract void Validate();
}
