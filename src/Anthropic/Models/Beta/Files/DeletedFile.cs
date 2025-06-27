using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using DeletedFileProperties = Anthropic.Models.Beta.Files.DeletedFileProperties;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Files;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<DeletedFile>))]
public sealed record class DeletedFile : Anthropic::ModelBase, Anthropic::IFromRaw<DeletedFile>
{
    /// <summary>
    /// ID of the deleted file.
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
    /// Deleted object type.
    ///
    /// For file deletion, this is always `"file_deleted"`.
    /// </summary>
    public DeletedFileProperties::Type? Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out Json::JsonElement element))
                return null;

            return Json::JsonSerializer.Deserialize<DeletedFileProperties::Type?>(element);
        }
        set { this.Properties["type"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Type?.Validate();
    }

    public DeletedFile() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    DeletedFile(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static DeletedFile FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
