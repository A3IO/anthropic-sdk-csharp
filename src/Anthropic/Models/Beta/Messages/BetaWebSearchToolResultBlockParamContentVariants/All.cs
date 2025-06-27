using Anthropic = Anthropic;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaWebSearchToolResultBlockParamContentVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        ResultBlock,
        Generic::List<Messages::BetaWebSearchResultBlockParam>
    >)
)]
public sealed record class ResultBlock(Generic::List<Messages::BetaWebSearchResultBlockParam> Value)
    : Messages::BetaWebSearchToolResultBlockParamContent,
        Anthropic::IVariant<ResultBlock, Generic::List<Messages::BetaWebSearchResultBlockParam>>
{
    public static ResultBlock From(Generic::List<Messages::BetaWebSearchResultBlockParam> value)
    {
        return new(value);
    }

    public override void Validate() { }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaWebSearchToolRequestError,
        Messages::BetaWebSearchToolRequestError
    >)
)]
public sealed record class BetaWebSearchToolRequestError(
    Messages::BetaWebSearchToolRequestError Value
)
    : Messages::BetaWebSearchToolResultBlockParamContent,
        Anthropic::IVariant<BetaWebSearchToolRequestError, Messages::BetaWebSearchToolRequestError>
{
    public static BetaWebSearchToolRequestError From(Messages::BetaWebSearchToolRequestError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
