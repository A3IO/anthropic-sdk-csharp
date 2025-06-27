using Anthropic = Anthropic;
using BetaCodeExecutionToolResultBlockParamContentVariants = Anthropic.Models.Beta.Messages.BetaCodeExecutionToolResultBlockParamContentVariants;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(
    typeof(Anthropic::UnionConverter<BetaCodeExecutionToolResultBlockParamContent>)
)]
public abstract record class BetaCodeExecutionToolResultBlockParamContent
{
    internal BetaCodeExecutionToolResultBlockParamContent() { }

    public static BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionToolResultErrorParam Create(
        BetaCodeExecutionToolResultErrorParam value
    ) => new(value);

    public static BetaCodeExecutionToolResultBlockParamContentVariants::BetaCodeExecutionResultBlockParam Create(
        BetaCodeExecutionResultBlockParam value
    ) => new(value);

    public abstract void Validate();
}
