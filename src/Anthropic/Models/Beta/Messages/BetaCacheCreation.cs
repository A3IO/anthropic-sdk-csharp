using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<BetaCacheCreation>))]
public sealed record class BetaCacheCreation
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<BetaCacheCreation>
{
    /// <summary>
    /// The number of input tokens used to create the 1 hour cache entry.
    /// </summary>
    public required long Ephemeral1hInputTokens
    {
        get
        {
            if (
                !this.Properties.TryGetValue(
                    "ephemeral_1h_input_tokens",
                    out Json::JsonElement element
                )
            )
                throw new System::ArgumentOutOfRangeException(
                    "ephemeral_1h_input_tokens",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<long>(element);
        }
        set
        {
            this.Properties["ephemeral_1h_input_tokens"] = Json::JsonSerializer.SerializeToElement(
                value
            );
        }
    }

    /// <summary>
    /// The number of input tokens used to create the 5 minute cache entry.
    /// </summary>
    public required long Ephemeral5mInputTokens
    {
        get
        {
            if (
                !this.Properties.TryGetValue(
                    "ephemeral_5m_input_tokens",
                    out Json::JsonElement element
                )
            )
                throw new System::ArgumentOutOfRangeException(
                    "ephemeral_5m_input_tokens",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<long>(element);
        }
        set
        {
            this.Properties["ephemeral_5m_input_tokens"] = Json::JsonSerializer.SerializeToElement(
                value
            );
        }
    }

    public override void Validate() { }

    public BetaCacheCreation() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    BetaCacheCreation(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static BetaCacheCreation FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
