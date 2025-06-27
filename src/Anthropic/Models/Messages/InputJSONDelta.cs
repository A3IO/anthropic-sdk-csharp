using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using InputJSONDeltaProperties = Anthropic.Models.Messages.InputJSONDeltaProperties;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<InputJSONDelta>))]
public sealed record class InputJSONDelta
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<InputJSONDelta>
{
    public required string PartialJSON
    {
        get
        {
            if (!this.Properties.TryGetValue("partial_json", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "partial_json",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<string>(element)
                ?? throw new System::ArgumentNullException("partial_json");
        }
        set { this.Properties["partial_json"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public required InputJSONDeltaProperties::Type Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("type", "Missing required argument");

            return Json::JsonSerializer.Deserialize<InputJSONDeltaProperties::Type>(element)
                ?? throw new System::ArgumentNullException("type");
        }
        set { this.Properties["type"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Type.Validate();
    }

    public InputJSONDelta() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    InputJSONDelta(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static InputJSONDelta FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
