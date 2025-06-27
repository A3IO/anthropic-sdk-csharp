using Anthropic = Anthropic;
using CacheControlEphemeralProperties = Anthropic.Models.Messages.CacheControlEphemeralProperties;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<CacheControlEphemeral>))]
public sealed record class CacheControlEphemeral
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<CacheControlEphemeral>
{
    public required CacheControlEphemeralProperties::Type Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("type", "Missing required argument");

            return Json::JsonSerializer.Deserialize<CacheControlEphemeralProperties::Type>(element)
                ?? throw new System::ArgumentNullException("type");
        }
        set { this.Properties["type"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Type.Validate();
    }

    public CacheControlEphemeral() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    CacheControlEphemeral(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static CacheControlEphemeral FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
