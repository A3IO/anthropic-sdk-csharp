using Anthropic = Anthropic;
using Generic = System.Collections.Generic;
using Serialization = System.Text.Json.Serialization;
using WebSearchToolResultBlockContentVariants = Anthropic.Models.Messages.WebSearchToolResultBlockContentVariants;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<WebSearchToolResultBlockContent>))]
public abstract record class WebSearchToolResultBlockContent
{
    internal WebSearchToolResultBlockContent() { }

    public static WebSearchToolResultBlockContentVariants::WebSearchToolResultError Create(
        WebSearchToolResultError value
    ) => new(value);

    public static WebSearchToolResultBlockContentVariants::UnionMember1 Create(
        Generic::List<WebSearchResultBlock> value
    ) => new(value);

    public abstract void Validate();
}
