using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<Metadata>))]
public sealed record class Metadata : Anthropic::ModelBase, Anthropic::IFromRaw<Metadata>
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

    public Metadata() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    Metadata(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Metadata FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
