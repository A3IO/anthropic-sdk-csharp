using Anthropic = Anthropic;
using Generic = System.Collections.Generic;
using Serialization = System.Text.Json.Serialization;
using WebSearchToolResultBlockParamContentVariants = Anthropic.Models.Messages.WebSearchToolResultBlockParamContentVariants;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(
    typeof(Anthropic::UnionConverter<WebSearchToolResultBlockParamContent>)
)]
public abstract record class WebSearchToolResultBlockParamContent
{
    internal WebSearchToolResultBlockParamContent() { }

    public static WebSearchToolResultBlockParamContentVariants::WebSearchToolResultBlockItem Create(
        Generic::List<WebSearchResultBlockParam> value
    ) => new(value);

    public static WebSearchToolResultBlockParamContentVariants::WebSearchToolRequestError Create(
        WebSearchToolRequestError value
    ) => new(value);

    public abstract void Validate();
}
