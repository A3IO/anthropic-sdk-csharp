using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(
    typeof(Anthropic::ModelConverter<BetaRequestMCPServerToolConfiguration>)
)]
public sealed record class BetaRequestMCPServerToolConfiguration
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<BetaRequestMCPServerToolConfiguration>
{
    public Generic::List<string>? AllowedTools
    {
        get
        {
            if (!this.Properties.TryGetValue("allowed_tools", out Json::JsonElement element))
                return null;

            return Json::JsonSerializer.Deserialize<Generic::List<string>?>(element);
        }
        set { this.Properties["allowed_tools"] = Json::JsonSerializer.SerializeToElement(value); }
    }

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

    public BetaRequestMCPServerToolConfiguration() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    BetaRequestMCPServerToolConfiguration(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static BetaRequestMCPServerToolConfiguration FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
