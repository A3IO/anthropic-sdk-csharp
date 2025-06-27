using Anthropic = Anthropic;
using MessageCountTokensToolProperties = Anthropic.Models.Messages.MessageCountTokensToolProperties;
using MessageCountTokensToolVariants = Anthropic.Models.Messages.MessageCountTokensToolVariants;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<MessageCountTokensTool>))]
public abstract record class MessageCountTokensTool
{
    internal MessageCountTokensTool() { }

    public static MessageCountTokensToolVariants::Tool Create(Tool value) => new(value);

    public static MessageCountTokensToolVariants::ToolBash20250124 Create(ToolBash20250124 value) =>
        new(value);

    public static MessageCountTokensToolVariants::ToolTextEditor20250124 Create(
        ToolTextEditor20250124 value
    ) => new(value);

    public static MessageCountTokensToolVariants::TextEditor20250429 Create(
        MessageCountTokensToolProperties::TextEditor20250429 value
    ) => new(value);

    public static MessageCountTokensToolVariants::WebSearchTool20250305 Create(
        WebSearchTool20250305 value
    ) => new(value);

    public abstract void Validate();
}
