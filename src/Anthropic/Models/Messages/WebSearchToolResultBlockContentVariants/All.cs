using Anthropic = Anthropic;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.WebSearchToolResultBlockContentVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        WebSearchToolResultError,
        Messages::WebSearchToolResultError
    >)
)]
public sealed record class WebSearchToolResultError(Messages::WebSearchToolResultError Value)
    : Messages::WebSearchToolResultBlockContent,
        Anthropic::IVariant<WebSearchToolResultError, Messages::WebSearchToolResultError>
{
    public static WebSearchToolResultError From(Messages::WebSearchToolResultError value)
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
        WebSearchResultBlocks,
        Generic::List<Messages::WebSearchResultBlock>
    >)
)]
public sealed record class WebSearchResultBlocks(
    Generic::List<Messages::WebSearchResultBlock> Value
)
    : Messages::WebSearchToolResultBlockContent,
        Anthropic::IVariant<WebSearchResultBlocks, Generic::List<Messages::WebSearchResultBlock>>
{
    public static WebSearchResultBlocks From(Generic::List<Messages::WebSearchResultBlock> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
