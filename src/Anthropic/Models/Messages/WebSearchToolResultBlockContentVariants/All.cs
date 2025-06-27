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
    typeof(Anthropic::VariantConverter<UnionMember1, Generic::List<Messages::WebSearchResultBlock>>)
)]
public sealed record class UnionMember1(Generic::List<Messages::WebSearchResultBlock> Value)
    : Messages::WebSearchToolResultBlockContent,
        Anthropic::IVariant<UnionMember1, Generic::List<Messages::WebSearchResultBlock>>
{
    public static UnionMember1 From(Generic::List<Messages::WebSearchResultBlock> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
