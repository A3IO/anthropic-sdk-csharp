using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using MessageBatchSucceededResultProperties = Anthropic.Models.Messages.Batches.MessageBatchSucceededResultProperties;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages.Batches;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<MessageBatchSucceededResult>))]
public sealed record class MessageBatchSucceededResult
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<MessageBatchSucceededResult>
{
    public required Messages::Message Message
    {
        get
        {
            if (!this.Properties.TryGetValue("message", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "message",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<Messages::Message>(element)
                ?? throw new System::ArgumentNullException("message");
        }
        set { this.Properties["message"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public required MessageBatchSucceededResultProperties::Type Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("type", "Missing required argument");

            return Json::JsonSerializer.Deserialize<MessageBatchSucceededResultProperties::Type>(
                    element
                ) ?? throw new System::ArgumentNullException("type");
        }
        set { this.Properties["type"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Message.Validate();
        this.Type.Validate();
    }

    public MessageBatchSucceededResult() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    MessageBatchSucceededResult(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static MessageBatchSucceededResult FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
