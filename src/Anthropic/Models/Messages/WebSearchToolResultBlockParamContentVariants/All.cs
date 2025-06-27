using Anthropic = Anthropic;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.WebSearchToolResultBlockParamContentVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        WebSearchToolResultBlockItem,
        Generic::List<Messages::WebSearchResultBlockParam>
    >)
)]
public sealed record class WebSearchToolResultBlockItem(
    Generic::List<Messages::WebSearchResultBlockParam> Value
)
    : Messages::WebSearchToolResultBlockParamContent,
        Anthropic::IVariant<
            WebSearchToolResultBlockItem,
            Generic::List<Messages::WebSearchResultBlockParam>
        >
{
    public static WebSearchToolResultBlockItem From(
        Generic::List<Messages::WebSearchResultBlockParam> value
    )
    {
        return new(value);
    }

    public override void Validate() { }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        WebSearchToolRequestError,
        Messages::WebSearchToolRequestError
    >)
)]
public sealed record class WebSearchToolRequestError(Messages::WebSearchToolRequestError Value)
    : Messages::WebSearchToolResultBlockParamContent,
        Anthropic::IVariant<WebSearchToolRequestError, Messages::WebSearchToolRequestError>
{
    public static WebSearchToolRequestError From(Messages::WebSearchToolRequestError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
