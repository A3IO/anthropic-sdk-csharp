using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;
using ToolChoiceNoneProperties = Anthropic.Models.Messages.ToolChoiceNoneProperties;

namespace Anthropic.Models.Messages;

/// <summary>
/// The model will not be allowed to use tools.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<ToolChoiceNone>))]
public sealed record class ToolChoiceNone
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<ToolChoiceNone>
{
    public required ToolChoiceNoneProperties::Type Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("type", "Missing required argument");

            return Json::JsonSerializer.Deserialize<ToolChoiceNoneProperties::Type>(element)
                ?? throw new System::ArgumentNullException("type");
        }
        set { this.Properties["type"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Type.Validate();
    }

    public ToolChoiceNone() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    ToolChoiceNone(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ToolChoiceNone FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
