using Anthropic = Anthropic;
using BetaToolProperties = Anthropic.Models.Beta.Messages.BetaToolProperties;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<BetaTool>))]
public sealed record class BetaTool : Anthropic::ModelBase, Anthropic::IFromRaw<BetaTool>
{
    /// <summary>
    /// [JSON schema](https://json-schema.org/draft/2020-12) for this tool's input.
    ///
    /// This defines the shape of the `input` that your tool accepts and that the model
    /// will produce.
    /// </summary>
    public required BetaToolProperties::InputSchema InputSchema
    {
        get
        {
            if (!this.Properties.TryGetValue("input_schema", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "input_schema",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<BetaToolProperties::InputSchema>(element)
                ?? throw new System::ArgumentNullException("input_schema");
        }
        set { this.Properties["input_schema"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// Name of the tool.
    ///
    /// This is how the tool will be called by the model and in `tool_use` blocks.
    /// </summary>
    public required string Name
    {
        get
        {
            if (!this.Properties.TryGetValue("name", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException("name", "Missing required argument");

            return Json::JsonSerializer.Deserialize<string>(element)
                ?? throw new System::ArgumentNullException("name");
        }
        set { this.Properties["name"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// Create a cache control breakpoint at this content block.
    /// </summary>
    public BetaCacheControlEphemeral? CacheControl
    {
        get
        {
            if (!this.Properties.TryGetValue("cache_control", out Json::JsonElement element))
                return null;

            return Json::JsonSerializer.Deserialize<BetaCacheControlEphemeral?>(element);
        }
        set { this.Properties["cache_control"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// Description of what this tool does.
    ///
    /// Tool descriptions should be as detailed as possible. The more information that
    /// the model has about what the tool is and how to use it, the better it will
    /// perform. You can use natural language descriptions to reinforce important aspects
    /// of the tool input JSON schema.
    /// </summary>
    public string? Description
    {
        get
        {
            if (!this.Properties.TryGetValue("description", out Json::JsonElement element))
                return null;

            return Json::JsonSerializer.Deserialize<string?>(element);
        }
        set { this.Properties["description"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public BetaToolProperties::Type? Type
    {
        get
        {
            if (!this.Properties.TryGetValue("type", out Json::JsonElement element))
                return null;

            return Json::JsonSerializer.Deserialize<BetaToolProperties::Type?>(element);
        }
        set { this.Properties["type"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.InputSchema.Validate();
        this.CacheControl?.Validate();
        this.Type?.Validate();
    }

    public BetaTool() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    BetaTool(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static BetaTool FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
