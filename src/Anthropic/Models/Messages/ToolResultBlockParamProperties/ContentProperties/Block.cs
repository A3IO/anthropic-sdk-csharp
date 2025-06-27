using Anthropic = Anthropic;
using BlockVariants = Anthropic.Models.Messages.ToolResultBlockParamProperties.ContentProperties.BlockVariants;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.ToolResultBlockParamProperties.ContentProperties;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<Block>))]
public abstract record class Block
{
    internal Block() { }

    public static BlockVariants::TextBlockParam Create(Messages::TextBlockParam value) =>
        new(value);

    public static BlockVariants::ImageBlockParam Create(Messages::ImageBlockParam value) =>
        new(value);

    public abstract void Validate();
}
