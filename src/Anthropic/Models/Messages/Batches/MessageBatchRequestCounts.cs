using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages.Batches;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<MessageBatchRequestCounts>))]
public sealed record class MessageBatchRequestCounts
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<MessageBatchRequestCounts>
{
    /// <summary>
    /// Number of requests in the Message Batch that have been canceled.
    ///
    /// This is zero until processing of the entire Message Batch has ended.
    /// </summary>
    public required long Canceled
    {
        get
        {
            if (!this.Properties.TryGetValue("canceled", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "canceled",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<long>(element);
        }
        set { this.Properties["canceled"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// Number of requests in the Message Batch that encountered an error.
    ///
    /// This is zero until processing of the entire Message Batch has ended.
    /// </summary>
    public required long Errored
    {
        get
        {
            if (!this.Properties.TryGetValue("errored", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "errored",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<long>(element);
        }
        set { this.Properties["errored"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// Number of requests in the Message Batch that have expired.
    ///
    /// This is zero until processing of the entire Message Batch has ended.
    /// </summary>
    public required long Expired
    {
        get
        {
            if (!this.Properties.TryGetValue("expired", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "expired",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<long>(element);
        }
        set { this.Properties["expired"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// Number of requests in the Message Batch that are processing.
    /// </summary>
    public required long Processing
    {
        get
        {
            if (!this.Properties.TryGetValue("processing", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "processing",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<long>(element);
        }
        set { this.Properties["processing"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// Number of requests in the Message Batch that have completed successfully.
    ///
    /// This is zero until processing of the entire Message Batch has ended.
    /// </summary>
    public required long Succeeded
    {
        get
        {
            if (!this.Properties.TryGetValue("succeeded", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "succeeded",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<long>(element);
        }
        set { this.Properties["succeeded"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate() { }

    public MessageBatchRequestCounts() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    MessageBatchRequestCounts(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static MessageBatchRequestCounts FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
