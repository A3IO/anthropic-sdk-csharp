using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages.Batches;

/// <summary>
/// This is a single line in the response `.jsonl` file and does not represent the
/// response as a whole.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<MessageBatchIndividualResponse>))]
public sealed record class MessageBatchIndividualResponse
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<MessageBatchIndividualResponse>
{
    /// <summary>
    /// Developer-provided ID created for each request in a Message Batch. Useful for
    /// matching results to requests, as results may be given out of request order.
    ///
    /// Must be unique for each request within the Message Batch.
    /// </summary>
    public required string CustomID
    {
        get
        {
            if (!this.Properties.TryGetValue("custom_id", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "custom_id",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<string>(element)
                ?? throw new System::ArgumentNullException("custom_id");
        }
        set { this.Properties["custom_id"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// Processing result for this request.
    ///
    /// Contains a Message output if processing was successful, an error response if
    /// processing failed, or the reason why processing was not attempted, such as cancellation
    /// or expiration.
    /// </summary>
    public required MessageBatchResult Result
    {
        get
        {
            if (!this.Properties.TryGetValue("result", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "result",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<MessageBatchResult>(element)
                ?? throw new System::ArgumentNullException("result");
        }
        set { this.Properties["result"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Result.Validate();
    }

    public MessageBatchIndividualResponse() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    MessageBatchIndividualResponse(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static MessageBatchIndividualResponse FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
