using Anthropic = Anthropic;
using BetaContainerUploadBlockProperties = Anthropic.Models.Beta.Messages.BetaContainerUploadBlockProperties;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages;

/// <summary>
/// Response model for a file uploaded to the container.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<BetaContainerUploadBlock>))]
public sealed record class BetaContainerUploadBlock
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<BetaContainerUploadBlock>
{
    public required string FileID
    {
        get
        {
            if (!this.Properties.TryGetValue("file_id", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "file_id",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<string>(element)
                ?? throw new System::ArgumentNullException("file_id");
        }
        set { this.Properties["file_id"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public required BetaContainerUploadBlockProperties::Type Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("type", "Missing required argument");

            return Json::JsonSerializer.Deserialize<BetaContainerUploadBlockProperties::Type>(
                    element
                ) ?? throw new System::ArgumentNullException("type");
        }
        set { this.Properties["type"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Type.Validate();
    }

    public BetaContainerUploadBlock() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    BetaContainerUploadBlock(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static BetaContainerUploadBlock FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
