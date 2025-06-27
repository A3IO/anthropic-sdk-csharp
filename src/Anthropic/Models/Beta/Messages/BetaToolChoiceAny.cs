using Anthropic = Anthropic;
using BetaToolChoiceAnyProperties = Anthropic.Models.Beta.Messages.BetaToolChoiceAnyProperties;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages;

/// <summary>
/// The model will use any available tools.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<BetaToolChoiceAny>))]
public sealed record class BetaToolChoiceAny
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<BetaToolChoiceAny>
{
    public required BetaToolChoiceAnyProperties::Type Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("type", "Missing required argument");

            return Json::JsonSerializer.Deserialize<BetaToolChoiceAnyProperties::Type>(element)
                ?? throw new System::ArgumentNullException("type");
        }
        set { this.Properties["type"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// Whether to disable parallel tool use.
    ///
    /// Defaults to `false`. If set to `true`, the model will output exactly one tool use.
    /// </summary>
    public bool? DisableParallelToolUse
    {
        get
        {
            if (
                !this.Properties.TryGetValue(
                    "disable_parallel_tool_use",
                    out Json::JsonElement element
                )
            )
                return null;

            return Json::JsonSerializer.Deserialize<bool?>(element);
        }
        set
        {
            this.Properties["disable_parallel_tool_use"] = Json::JsonSerializer.SerializeToElement(
                value
            );
        }
    }

    public override void Validate()
    {
        this.Type.Validate();
    }

    public BetaToolChoiceAny() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    BetaToolChoiceAny(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static BetaToolChoiceAny FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
