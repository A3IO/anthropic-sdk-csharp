using Anthropic = Anthropic;
using BetaToolResultBlockParamProperties = Anthropic.Models.Beta.Messages.BetaToolResultBlockParamProperties;
using ContentProperties = Anthropic.Models.Beta.Messages.BetaToolResultBlockParamProperties.ContentProperties;
using Generic = System.Collections.Generic;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.BetaToolResultBlockParamProperties.ContentVariants;

[Serialization::JsonConverter(typeof(Anthropic::VariantConverter<String, string>))]
public sealed record class String(string Value)
    : BetaToolResultBlockParamProperties::Content,
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
    : BetaToolResultBlockParamProperties::Content,
        Anthropic::IVariant<Blocks, Generic::List<ContentProperties::Block>>
{
    public static Blocks From(Generic::List<ContentProperties::Block> value)
    {
        return new(value);
    }

    public override void Validate() { }
}
