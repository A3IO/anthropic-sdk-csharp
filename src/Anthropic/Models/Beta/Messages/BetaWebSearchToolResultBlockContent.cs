using Anthropic = Anthropic;
using BetaWebSearchToolResultBlockContentVariants = Anthropic.Models.Beta.Messages.BetaWebSearchToolResultBlockContentVariants;
using Generic = System.Collections.Generic;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(
    typeof(Anthropic::UnionConverter<BetaWebSearchToolResultBlockContent>)
)]
public abstract record class BetaWebSearchToolResultBlockContent
{
    internal BetaWebSearchToolResultBlockContent() { }

    public static BetaWebSearchToolResultBlockContentVariants::BetaWebSearchToolResultError Create(
        BetaWebSearchToolResultError value
    ) => new(value);

    public static BetaWebSearchToolResultBlockContentVariants::UnionMember1 Create(
        Generic::List<BetaWebSearchResultBlock> value
    ) => new(value);

    public abstract void Validate();
}
