using Anthropic = Anthropic;
using ContentProperties = Anthropic.Models.Messages.ToolResultBlockParamProperties.ContentProperties;
using Generic = System.Collections.Generic;
using Serialization = System.Text.Json.Serialization;
using ToolResultBlockParamProperties = Anthropic.Models.Messages.ToolResultBlockParamProperties;

namespace Anthropic.Models.Messages.ToolResultBlockParamProperties.ContentVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<String, string>))]
public sealed record class String(string Value)
    : ToolResultBlockParamProperties::Content,
        Anthropic::IVariant<String, string>
{
    public static String From(string value)
    {
        return new(value);
    }

    public override void Validate() { }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<Blocks, Generic::List<ContentProperties::Block>>)
)]
public sealed record class Blocks(Generic::List<ContentProperties::Block> Value)
    : ToolResultBlockParamProperties::Content,
        Anthropic::IVariant<Blocks, Generic::List<ContentProperties::Block>>
{
    public static Blocks From(Generic::List<ContentProperties::Block> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
