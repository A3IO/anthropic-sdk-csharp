using Anthropic = Anthropic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaCodeExecutionToolResultBlockParamContentVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaCodeExecutionToolResultErrorParam,
        Messages::BetaCodeExecutionToolResultErrorParam
    >)
)]
public sealed record class BetaCodeExecutionToolResultErrorParam(
    Messages::BetaCodeExecutionToolResultErrorParam Value
)
    : Messages::BetaCodeExecutionToolResultBlockParamContent,
        Anthropic::IVariant<
            BetaCodeExecutionToolResultErrorParam,
            Messages::BetaCodeExecutionToolResultErrorParam
        >
{
    public static BetaCodeExecutionToolResultErrorParam From(
        Messages::BetaCodeExecutionToolResultErrorParam value
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
        BetaCodeExecutionResultBlockParam,
        Messages::BetaCodeExecutionResultBlockParam
    >)
)]
public sealed record class BetaCodeExecutionResultBlockParam(
    Messages::BetaCodeExecutionResultBlockParam Value
)
    : Messages::BetaCodeExecutionToolResultBlockParamContent,
        Anthropic::IVariant<
            BetaCodeExecutionResultBlockParam,
            Messages::BetaCodeExecutionResultBlockParam
        >
{
    public static BetaCodeExecutionResultBlockParam From(
        Messages::BetaCodeExecutionResultBlockParam value
    )
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
