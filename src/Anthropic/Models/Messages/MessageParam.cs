using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using MessageParamProperties = Anthropic.Models.Messages.MessageParamProperties;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<MessageParam>))]
public sealed record class MessageParam : Anthropic::ModelBase, Anthropic::IFromRaw<MessageParam>
{
    public required MessageParamProperties::Content Content
    {
        get
        {
            if (!this.Properties.TryGetValue("content", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "content",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<MessageParamProperties::Content>(element)
                ?? throw new System::ArgumentNullException("content");
        }
        set { this.Properties["content"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public required MessageParamProperties::Role Role
    {
        get
        {
            if (!this.Properties.TryGetValue("role", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("role", "Missing required argument");

            return Json::JsonSerializer.Deserialize<MessageParamProperties::Role>(element)
                ?? throw new System::ArgumentNullException("role");
        }
        set { this.Properties["role"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Content.Validate();
        this.Role.Validate();
    }

    public MessageParam() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    MessageParam(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static MessageParam FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
