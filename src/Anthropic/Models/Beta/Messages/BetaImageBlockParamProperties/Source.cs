using Anthropic = Anthropic;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;
using SourceVariants = Anthropic.Models.Beta.Messages.BetaImageBlockParamProperties.SourceVariants;

namespace Anthropic.Models.Beta.Messages.BetaImageBlockParamProperties;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<Source>))]
public abstract record class Source
{
    internal Source() { }

    public static SourceVariants::BetaBase64ImageSource Create(
        Messages::BetaBase64ImageSource value
    ) => new(value);

    public static SourceVariants::BetaURLImageSource Create(Messages::BetaURLImageSource value) =>
        new(value);

    public static SourceVariants::BetaFileImageSource Create(Messages::BetaFileImageSource value) =>
        new(value);

    public abstract void Validate();
}
