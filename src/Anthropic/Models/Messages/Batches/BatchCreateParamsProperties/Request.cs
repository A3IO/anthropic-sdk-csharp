using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using RequestProperties = Anthropic.Models.Messages.Batches.BatchCreateParamsProperties.RequestProperties;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages.Batches.BatchCreateParamsProperties;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<Request>))]
public sealed record class Request : Anthropic::ModelBase, Anthropic::IFromRaw<Request>
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
    /// Messages API creation parameters for the individual request.
    ///
    /// See the [Messages API reference](/en/api/messages) for full documentation on
    /// available parameters.
    /// </summary>
    public required RequestProperties::Params Params
    {
        get
        {
            if (!this.Properties.TryGetValue("params", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "params",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<RequestProperties::Params>(element)
                ?? throw new System::ArgumentNullException("params");
        }
        set { this.Properties["params"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Params.Validate();
    }

    public Request() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    Request(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static Request FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
