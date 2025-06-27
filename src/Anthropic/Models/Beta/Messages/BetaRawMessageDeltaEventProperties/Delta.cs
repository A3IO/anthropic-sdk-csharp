using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Messages = Anthropic.Models.Beta.Messages;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages.BetaRawMessageDeltaEventProperties;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<Delta>))]
public sealed record class Delta : Anthropic::ModelBase, Anthropic::IFromRaw<Delta>
{
    /// <summary>
    /// Information about the container used in the request (for the code execution tool)
    /// </summary>
    public required Messages::BetaContainer? Container
    {
        get
        {
            if (!this.Properties.TryGetValue("container", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "container",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<Messages::BetaContainer?>(element);
        }
        set { this.Properties["container"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public required Messages::BetaStopReason? StopReason
    {
        get
        {
            if (!this.Properties.TryGetValue("stop_reason", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "stop_reason",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<Messages::BetaStopReason?>(element);
        }
        set { this.Properties["stop_reason"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public required string? StopSequence
    {
        get
        {
            if (!this.Properties.TryGetValue("stop_sequence", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "stop_sequence",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<string?>(element);
        }
        set { this.Properties["stop_sequence"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Container?.Validate();
        this.StopReason?.Validate();
    }

    public Delta() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    Delta(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Delta FromRawUnchecked(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        return new(properties);
    }
}
