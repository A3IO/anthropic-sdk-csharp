using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using RedactedThinkingBlockParamProperties = Anthropic.Models.Messages.RedactedThinkingBlockParamProperties;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<RedactedThinkingBlockParam>))]
public sealed record class RedactedThinkingBlockParam
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<RedactedThinkingBlockParam>
{
    public required string Data
    {
        get
        {
            if (!this.Properties.TryGetValue("data", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("data", "Missing required argument");

            return Json::JsonSerializer.Deserialize<string>(element)
                ?? throw new System::ArgumentNullException("data");
        }
        set { this.Properties["data"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public required RedactedThinkingBlockParamProperties::Type Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("type", "Missing required argument");

            return Json::JsonSerializer.Deserialize<RedactedThinkingBlockParamProperties::Type>(
                    element
                ) ?? throw new System::ArgumentNullException("type");
        }
        set { this.Properties["type"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Type.Validate();
    }

    public RedactedThinkingBlockParam() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    RedactedThinkingBlockParam(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static RedactedThinkingBlockParam FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
