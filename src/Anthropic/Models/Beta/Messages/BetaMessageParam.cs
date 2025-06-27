using Anthropic = Anthropic;
using BetaMessageParamProperties = Anthropic.Models.Beta.Messages.BetaMessageParamProperties;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<BetaMessageParam>))]
public sealed record class BetaMessageParam
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<BetaMessageParam>
{
    public required BetaMessageParamProperties::Content Content
    {
        get
        {
            if (!this.Properties.TryGetValue("content", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "content",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<BetaMessageParamProperties::Content>(element)
                ?? throw new System::ArgumentNullException("content");
        }
        set { this.Properties["content"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public required BetaMessageParamProperties::Role Role
    {
        get
        {
            if (!this.Properties.TryGetValue("role", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("role", "Missing required argument");

            return Json::JsonSerializer.Deserialize<BetaMessageParamProperties::Role>(element)
                ?? throw new System::ArgumentNullException("role");
        }
        set { this.Properties["role"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Content.Validate();
        this.Role.Validate();
    }

    public BetaMessageParam() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    BetaMessageParam(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static BetaMessageParam FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
