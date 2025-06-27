using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages;

/// <summary>
/// Information about the container used in the request (for the code execution tool)
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<BetaContainer>))]
public sealed record class BetaContainer : Anthropic::ModelBase, Anthropic::IFromRaw<BetaContainer>
{
    /// <summary>
    /// Identifier for the container used in this request
    /// </summary>
    public required string ID
    {
        get
        {
            if (!this.Properties.TryGetValue("id", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("id", "Missing required argument");

            return Json::JsonSerializer.Deserialize<string>(element)
                ?? throw new System::ArgumentNullException("id");
        }
        set { this.Properties["id"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// The time at which the container will expire.
    /// </summary>
    public required System::DateTime ExpiresAt
    {
        get
        {
            if (!this.Properties.TryGetValue("expires_at", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "expires_at",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<System::DateTime>(element);
        }
        set { this.Properties["expires_at"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate() { }

    public BetaContainer() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    BetaContainer(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static BetaContainer FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
