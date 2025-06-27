using Anthropic = Anthropic;
using BetaThinkingDeltaProperties = Anthropic.Models.Beta.Messages.BetaThinkingDeltaProperties;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<BetaThinkingDelta>))]
public sealed record class BetaThinkingDelta
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<BetaThinkingDelta>
{
    public required string Thinking
    {
        get
        {
            if (!this.Properties.TryGetValue("thinking", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "thinking",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<string>(element)
                ?? throw new System::ArgumentNullException("thinking");
        }
        set { this.Properties["thinking"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public required BetaThinkingDeltaProperties::Type Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("type", "Missing required argument");

            return Json::JsonSerializer.Deserialize<BetaThinkingDeltaProperties::Type>(element)
                ?? throw new System::ArgumentNullException("type");
        }
        set { this.Properties["type"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Type.Validate();
    }

    public BetaThinkingDelta() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    BetaThinkingDelta(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static BetaThinkingDelta FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
