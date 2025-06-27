using Anthropic = Anthropic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaCodeExecutionToolResultBlockContentVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaCodeExecutionToolResultError,
        Messages::BetaCodeExecutionToolResultError
    >)
)]
public sealed record class BetaCodeExecutionToolResultError(
    Messages::BetaCodeExecutionToolResultError Value
)
    : Messages::BetaCodeExecutionToolResultBlockContent,
        Anthropic::IVariant<
            BetaCodeExecutionToolResultError,
            Messages::BetaCodeExecutionToolResultError
        >
{
    public static BetaCodeExecutionToolResultError From(
        Messages::BetaCodeExecutionToolResultError value
    )
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
        BetaCodeExecutionResultBlock,
        Messages::BetaCodeExecutionResultBlock
    >)
)]
public sealed record class BetaCodeExecutionResultBlock(
    Messages::BetaCodeExecutionResultBlock Value
)
    : Messages::BetaCodeExecutionToolResultBlockContent,
        Anthropic::IVariant<BetaCodeExecutionResultBlock, Messages::BetaCodeExecutionResultBlock>
{
    public static BetaCodeExecutionResultBlock From(Messages::BetaCodeExecutionResultBlock value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
