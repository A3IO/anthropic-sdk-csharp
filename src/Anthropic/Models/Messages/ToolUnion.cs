using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using ToolUnionProperties = Anthropic.Models.Messages.ToolUnionProperties;
using ToolUnionVariants = Anthropic.Models.Messages.ToolUnionVariants;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<ToolUnion>))]
public abstract record class ToolUnion
{
    internal ToolUnion() { }

    public static ToolUnionVariants::Tool Create(Tool value) => new(value);

    public static ToolUnionVariants::ToolBash20250124 Create(ToolBash20250124 value) => new(value);

    public static ToolUnionVariants::ToolTextEditor20250124 Create(ToolTextEditor20250124 value) =>
        new(value);

    public static ToolUnionVariants::TextEditor20250429 Create(
        ToolUnionProperties::TextEditor20250429 value
    ) => new(value);

    public static ToolUnionVariants::WebSearchTool20250305 Create(WebSearchTool20250305 value) =>
        new(value);

    public abstract void Validate();
}
