using Anthropic = Anthropic;
using BetaCodeExecutionToolResultBlockContentVariants = Anthropic.Models.Beta.Messages.BetaCodeExecutionToolResultBlockContentVariants;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(
    typeof(Anthropic::UnionConverter<BetaCodeExecutionToolResultBlockContent>)
)]
public abstract record class BetaCodeExecutionToolResultBlockContent
{
    internal BetaCodeExecutionToolResultBlockContent() { }

    public static BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionToolResultError Create(
        BetaCodeExecutionToolResultError value
    ) => new(value);

    public static BetaCodeExecutionToolResultBlockContentVariants::BetaCodeExecutionResultBlock Create(
        BetaCodeExecutionResultBlock value
    ) => new(value);

    public abstract void Validate();
}
