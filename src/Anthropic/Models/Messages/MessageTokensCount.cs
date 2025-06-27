using Anthropic = Anthropic;
using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages;

[Serialization::JsonConverter(typeof(Anthropic::ModelConverter<MessageTokensCount>))]
public sealed record class MessageTokensCount
    : Anthropic::ModelBase,
        Anthropic::IFromRaw<MessageTokensCount>
{
    /// <summary>
    /// The total number of tokens across the provided list of messages, system prompt,
    /// and tools.
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

    public override void Validate() { }

    public MessageTokensCount() { }

#pragma warning disable CS8618
    [CodeAnalysis::SetsRequiredMembers]
    MessageTokensCount(Generic::Dictionary<string, Json::JsonElement> properties)
    {
        Properties = properties;
    }
#pragma warning restore CS8618

    public static MessageTokensCount FromRawUnchecked(
        Generic::Dictionary<string, Json::JsonElement> properties
    )
    {
        return new(properties);
    }
}
