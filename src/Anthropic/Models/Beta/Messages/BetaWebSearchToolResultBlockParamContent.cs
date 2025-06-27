using Anthropic = Anthropic;
using BetaWebSearchToolResultBlockParamContentVariants = Anthropic.Models.Beta.Messages.BetaWebSearchToolResultBlockParamContentVariants;
using Generic = System.Collections.Generic;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(
    typeof(Anthropic::UnionConverter<BetaWebSearchToolResultBlockParamContent>)
)]
public abstract record class BetaWebSearchToolResultBlockParamContent
{
    internal BetaWebSearchToolResultBlockParamContent() { }

    public static BetaWebSearchToolResultBlockParamContentVariants::ResultBlock Create(
        Generic::List<BetaWebSearchResultBlockParam> value
    ) => new(value);

    public static BetaWebSearchToolResultBlockParamContentVariants::BetaWebSearchToolRequestError Create(
        BetaWebSearchToolRequestError value
    ) => new(value);

    public abstract void Validate();
}
