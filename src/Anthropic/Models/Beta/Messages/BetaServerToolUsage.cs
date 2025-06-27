using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Beta.Messages;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<BetaServerToolUsage>))]
public sealed record class BetaServerToolUsage
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<BetaServerToolUsage>
{
    /// <summary>
    /// The number of web search tool requests.
    /// </summary>
    public required long WebSearchRequests
    {
        get
        {
            if (!this.Properties.TryGetValue("web_search_requests", out Json::JsonElement element))
                throw new System::ArgumentOutOfRangeException(
                    "web_search_requests",
                    "Missing required argument"
                );

            return Json::JsonSerializer.Deserialize<long>(element);
        }
        set
        {
            this.Properties["web_search_requests"] = Json::JsonSerializer.SerializeToElement(value);
        }
    }

    public override void Validate() { }

    public BetaServerToolUsage() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    BetaServerToolUsage(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static BetaServerToolUsage FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
