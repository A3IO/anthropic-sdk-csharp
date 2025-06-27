using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<CitationsConfigParam>))]
public sealed record class CitationsConfigParam
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<CitationsConfigParam>
{
    public bool? Enabled
    {
        get
        {
            if (!this.Properties.TryGetValue("enabled", out Json::JsonElement element))
                return null;

            return Json::JsonSerializer.Deserialize<bool?>(element);
        }
        set { this.Properties["enabled"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate() { }

    public CitationsConfigParam() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    CitationsConfigParam(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static CitationsConfigParam FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
