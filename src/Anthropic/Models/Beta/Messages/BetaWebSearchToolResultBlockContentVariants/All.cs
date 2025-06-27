using Anthropic = Anthropic;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaWebSearchToolResultBlockContentVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaWebSearchToolResultError,
        Messages::BetaWebSearchToolResultError
    >)
)]
public sealed record class BetaWebSearchToolResultError(
    Messages::BetaWebSearchToolResultError Value
)
    : Messages::BetaWebSearchToolResultBlockContent,
        Anthropic::IVariant<BetaWebSearchToolResultError, Messages::BetaWebSearchToolResultError>
{
    public static BetaWebSearchToolResultError From(Messages::BetaWebSearchToolResultError value)
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
        UnionMember1,
        Generic::List<Messages::BetaWebSearchResultBlock>
    >)
)]
public sealed record class UnionMember1(Generic::List<Messages::BetaWebSearchResultBlock> Value)
    : Messages::BetaWebSearchToolResultBlockContent,
        Anthropic::IVariant<UnionMember1, Generic::List<Messages::BetaWebSearchResultBlock>>
{
    public static UnionMember1 From(Generic::List<Messages::BetaWebSearchResultBlock> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
