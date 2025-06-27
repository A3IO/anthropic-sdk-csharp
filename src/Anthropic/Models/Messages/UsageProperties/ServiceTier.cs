using Anthropic = Anthropic;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic.Models.Messages.UsageProperties;

/// <summary>
/// If the request used the priority, standard, or batch tier.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::EnumConverter<ServiceTier, string>))]
public sealed record class ServiceTier(string value) : Anthropic::IEnum<ServiceTier, string>
{
    public static readonly ServiceTier Standard = new("standard");

    public static readonly ServiceTier Priority = new("priority");

    public static readonly ServiceTier Batch = new("batch");

    readonly string _value = value;

    public enum Value
    {
        Standard,
        Priority,
        Batch,
    }

    public Value Known() =>
        _value switch
        {
            "standard" => Value.Standard,
            "priority" => Value.Priority,
            "batch" => Value.Batch,
            _ => throw new System::ArgumentOutOfRangeException(nameof(_value)),
        };

    public string Raw()
    {
        return _value;
    }

    public void Validate()
    {
        Known();
    }

    public static ServiceTier FromRaw(string value)
    {
        return new(value);
    }
}
