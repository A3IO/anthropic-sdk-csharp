using System.Text.Json;
using System.Text.Json.Serialization;
using Anthropic.Exceptions;
using System = System;

namespace Anthropic.Models.Beta.Dreams;

/// <summary>
/// Lifecycle status of a Dream.
/// </summary>
[JsonConverter(typeof(BetaDreamStatusConverter))]
public enum BetaDreamStatus
{
    /// <summary>
    /// The dream is waiting to start and hasn't read its inputs yet.
    ///
    /// <para>`outputs` is empty and every `usage` count is zero.</para>
    /// </summary>
    Pending,

    /// <summary>
    /// The dream is reading its inputs and writing its result.
    ///
    /// <para>`usage` updates while the dream has this status.</para>
    /// </summary>
    Running,

    /// <summary>
    /// The dream finished and its output memory store holds the complete result.
    /// </summary>
    Completed,

    /// <summary>
    /// The dream stopped with an error, which `error` describes.
    ///
    /// <para>If `outputs` references a memory store, that memory store keeps what
    /// the dream wrote before it stopped.</para>
    /// </summary>
    Failed,

    /// <summary>
    /// The caller canceled the dream before it completed.
    /// </summary>
    Canceled,
}

sealed class BetaDreamStatusConverter : JsonConverter<BetaDreamStatus>
{
    public override BetaDreamStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => BetaDreamStatus.Pending,
            "running" => BetaDreamStatus.Running,
            "completed" => BetaDreamStatus.Completed,
            "failed" => BetaDreamStatus.Failed,
            "canceled" => BetaDreamStatus.Canceled,
            _ => (BetaDreamStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        BetaDreamStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                BetaDreamStatus.Pending => "pending",
                BetaDreamStatus.Running => "running",
                BetaDreamStatus.Completed => "completed",
                BetaDreamStatus.Failed => "failed",
                BetaDreamStatus.Canceled => "canceled",
                _ => throw new AnthropicInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
