using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using ToolChoiceVariants = Anthropic.Models.Messages.ToolChoiceVariants;

namespace Anthropic.Models.Messages;

/// <summary>
/// How the model should use the provided tools. The model can use a specific tool,
/// any available tool, decide by itself, or not use tools at all.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<ToolChoice>))]
public abstract record class ToolChoice
{
    internal ToolChoice() { }

    public static ToolChoiceVariants::ToolChoiceAuto Create(ToolChoiceAuto value) => new(value);

    public static ToolChoiceVariants::ToolChoiceAny Create(ToolChoiceAny value) => new(value);

    public static ToolChoiceVariants::ToolChoiceTool Create(ToolChoiceTool value) => new(value);

    public static ToolChoiceVariants::ToolChoiceNone Create(ToolChoiceNone value) => new(value);

    public abstract void Validate();
}
