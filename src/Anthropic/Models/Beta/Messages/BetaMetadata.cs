using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<BetaMetadata>))]
public sealed record class BetaMetadata : Anthropic::ModelBase, Anthropic::IFromRaw<BetaMetadata>
{
    /// <summary>
    /// An external identifier for the user who is associated with the request.
    ///
    /// This should be a uuid, hash value, or other opaque identifier. Anthropic may
    /// use this id to help detect abuse. Do not include any identifying information
    /// such as name, email address, or phone number.
    /// </summary>
    public string? UserID
    {
        get
        {
            if (!this.Properties.TryGetValue("user_id", out Json::JsonElement element))
                return null;

            return Json::JsonSerializer.Deserialize<string?>(element);
        }
        set { this.Properties["user_id"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate() { }

    public BetaMetadata() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    BetaMetadata(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static BetaMetadata FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
