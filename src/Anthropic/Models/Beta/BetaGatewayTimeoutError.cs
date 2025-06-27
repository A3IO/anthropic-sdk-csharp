using Anthropic = Anthropic;
using BetaGatewayTimeoutErrorProperties = Anthropic.Models.Beta.BetaGatewayTimeoutErrorProperties;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<BetaGatewayTimeoutError>))]
public sealed record class BetaGatewayTimeoutError
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<BetaGatewayTimeoutError>
{
    public required string Message
    {
        get
        {
            if (!this.Properties.TryGetValue("message", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "message",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<string>(element)
                ?? throw new System::ArgumentNullException("message");
        }
        set { this.Properties["message"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public required BetaGatewayTimeoutErrorProperties::Type Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("type", "Missing required argument");

            return Json::JsonSerializer.Deserialize<BetaGatewayTimeoutErrorProperties::Type>(
                    element
                ) ?? throw new System::ArgumentNullException("type");
        }
        set { this.Properties["type"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Type.Validate();
    }

    public BetaGatewayTimeoutError() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    BetaGatewayTimeoutError(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static BetaGatewayTimeoutError FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
