using Anthropic = Anthropic;
using Generic = System.Collections.Generic;
using Messages = Anthropic.Models.Messages;
using Serialization = System.Text.Json.Serialization;
using SystemVariants = Anthropic.Models.Messages.Batches.BatchCreateParamsProperties.RequestProperties.ParamsProperties.SystemVariants;

namespace Anthropic.Models.Messages.Batches.BatchCreateParamsProperties.RequestProperties.ParamsProperties;

/// <summary>
/// System prompt.
///
/// A system prompt is a way of providing context and instructions to Claude, such
/// as specifying a particular goal or role. See our [guide to system prompts](https://docs.anthropic.com/en/docs/system-prompts).
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<System>))]
public abstract record class System
{
    internal System() { }

    public static SystemVariants::UnionMember0 Create(string value) => new(value);

    public static SystemVariants::UnionMember1 Create(
        Generic::List<Messages::TextBlockParam> value
    ) => new(value);

    public abstract void Validate();
}
