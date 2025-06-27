using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using ErrorResponseProperties = Anthropic.Models.ErrorResponseProperties;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<ErrorResponse>))]
public sealed record class ErrorResponse : Anthropic::ModelBase, Anthropic::IFromRaw<ErrorResponse>
{
    public required ErrorObject Error
    {
        get
        {
            if (!this.Properties.TryGetValue("error", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("error", "Missing required argument");

            return Json::JsonSerializer.Deserialize<ErrorObject>(element)
                ?? throw new System::ArgumentNullException("error");
        }
        set { this.Properties["error"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public required ErrorResponseProperties::Type Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("type", "Missing required argument");

            return Json::JsonSerializer.Deserialize<ErrorResponseProperties::Type>(element)
                ?? throw new System::ArgumentNullException("type");
        }
        set { this.Properties["type"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.Error.Validate();
        this.Type.Validate();
    }

    public ErrorResponse() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    ErrorResponse(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static ErrorResponse FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
