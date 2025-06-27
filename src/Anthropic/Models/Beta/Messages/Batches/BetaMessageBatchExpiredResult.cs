using Anthropic = Anthropic;
using BetaMessageBatchExpiredResultProperties = Anthropic.Models.Beta.Messages.Batches.BetaMessageBatchExpiredResultProperties;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages.Batches;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<BetaMessageBatchExpiredResult>))]
public sealed record class BetaMessageBatchExpiredResult
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<BetaMessageBatchExpiredResult>
{
    public required BetaMessageBatchExpiredResultProperties::Type Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("type", "Missing required argument");

            return Json::JsonSerializer.Deserialize<BetaMessageBatchExpiredResultProperties::Type>(
                    element
                ) ?? throw new System::ArgumentNullException("type");
        }
        set { this.Properties["type"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Type.Validate();
    }

    public BetaMessageBatchExpiredResult() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    BetaMessageBatchExpiredResult(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static BetaMessageBatchExpiredResult FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
