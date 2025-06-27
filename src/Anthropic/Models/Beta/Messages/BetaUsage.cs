using Anthropic = Anthropic;
using BetaUsageProperties = Anthropic.Models.Beta.Messages.BetaUsageProperties;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<BetaUsage>))]
public sealed record class BetaUsage : Anthropic::ModelBase, Anthropic::IFromRaw<BetaUsage>
{
    /// <summary>
    /// Breakdown of cached tokens by TTL
    /// </summary>
    public required BetaCacheCreation? CacheCreation
    {
        get
        {
            if (!this.Properties.TryGetValue("cache_creation", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "cache_creation",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<BetaCacheCreation?>(element);
        }
        set { this.Properties["cache_creation"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// The number of input tokens used to create the cache entry.
    /// </summary>
    public required long? CacheCreationInputTokens
    {
        get
        {
            if (
                !this.Properties.TryGetValue(
                    "cache_creation_input_tokens",
                    out Json::JsonElement element
                )
            )
                throw new System::ArgumentOutOfRangeException(
                    "cache_creation_input_tokens",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<long?>(element);
        }
        set
        {
            this.Properties["cache_creation_input_tokens"] =
                Json::JsonSerializer.SerializeToElement(value);
        }
    }

    /// <summary>
    /// The number of input tokens read from the cache.
    /// </summary>
    public required long? CacheReadInputTokens
    {
        get
        {
            if (
                !this.Properties.TryGetValue(
                    "cache_read_input_tokens",
                    out Json::JsonElement element
                )
            )
                throw new System::ArgumentOutOfRangeException(
                    "cache_read_input_tokens",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<long?>(element);
        }
        set
        {
            this.Properties["cache_read_input_tokens"] = Json::JsonSerializer.SerializeToElement(
                value
            );
        }
    }

    /// <summary>
    /// The number of input tokens which were used.
    /// </summary>
    public required long InputTokens
    {
        get
        {
            if (!this.Properties.TryGetValue("input_tokens", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "input_tokens",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<long>(element);
        }
        set { this.Properties["input_tokens"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// The number of output tokens which were used.
    /// </summary>
    public required long OutputTokens
    {
        get
        {
            if (!this.Properties.TryGetValue("output_tokens", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "output_tokens",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<long>(element);
        }
        set { this.Properties["output_tokens"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// The number of server tool requests.
    /// </summary>
    public required BetaServerToolUsage? ServerToolUse
    {
        get
        {
            if (!this.Properties.TryGetValue("server_tool_use", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "server_tool_use",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<BetaServerToolUsage?>(element);
        }
        set { this.Properties["server_tool_use"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    /// <summary>
    /// If the request used the priority, standard, or batch tier.
    /// </summary>
    public required BetaUsageProperties::ServiceTier? ServiceTier
    {
        get
        {
            if (!this.Properties.TryGetValue("service_tier", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "service_tier",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<BetaUsageProperties::ServiceTier?>(element);
        }
        set { this.Properties["service_tier"] = Json::JsonSerializer.SerializeToElement(value); }
    }

    public override void Validate()
    {
        this.CacheCreation?.Validate();
        this.ServerToolUse?.Validate();
        this.ServiceTier?.Validate();
    }

    public BetaUsage() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    BetaUsage(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static BetaUsage FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
