using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Anthropic.Core;
using Anthropic.Exceptions;
using System = System;

namespace Anthropic.Models.Beta.Messages;

[JsonConverter(
    typeof(JsonModelConverter<BetaRawMessageDeltaEvent, BetaRawMessageDeltaEventFromRaw>)
)]
public sealed record class BetaRawMessageDeltaEvent : JsonModel
{
    /// <summary>
    /// Information about context management strategies applied during the request
    /// </summary>
    public required BetaContextManagementResponse? ContextManagement
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<BetaContextManagementResponse>(
                "context_management"
            );
        }
        init { this._rawData.Set("context_management", value); }
    }

    public required Delta Delta
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<Delta>("delta");
        }
        init { this._rawData.Set("delta", value); }
    }

    public JsonElement Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<JsonElement>("type");
        }
        init { this._rawData.Set("type", value); }
    }

    /// <summary>
    /// Billing and rate-limit usage.
    ///
    /// <para>Anthropic's API bills and rate-limits by token counts, as tokens represent
    /// the underlying cost to our systems.</para>
    ///
    /// <para>Under the hood, the API transforms requests into a format suitable for
    /// the model. The model's output then goes through a parsing stage before becoming
    /// an API response. As a result, the token counts in `usage` will not match one-to-one
    /// with the exact visible content of an API request or response.</para>
    ///
    /// <para>For example, `output_tokens` will be non-zero, even for an empty string
    /// response from Claude.</para>
    ///
    /// <para>Total input tokens in a request is the summation of `input_tokens`,
    /// `cache_creation_input_tokens`, and `cache_read_input_tokens`.</para>
    /// </summary>
    public required BetaMessageDeltaUsage Usage
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<BetaMessageDeltaUsage>("usage");
        }
        init { this._rawData.Set("usage", value); }
    }

    /// <summary>
    /// Changes the API made to the request's input before showing it to the model,
    /// and blocks that failed a binding check but were left unchanged: one entry
    /// per block, in request order. Two entry types today. `thinking_dropped` —
    /// a `thinking`, `redacted_thinking` or `connector_text` block from the request's
    /// `messages` that was removed from the prompt instead of being shown to the
    /// model because it failed a binding check. `thinking_mismatch_allowed` — a
    /// `thinking` or `redacted_thinking` block that failed the conversation check
    /// (the conversation before it differs from the one it was created in, or it
    /// carries no record of one on a model that requires it) and was shown to the
    /// model all the same, because that check is not enforced for this request.
    /// More entry types may be added over time; ignore types you do not recognize.
    ///
    /// <para>Requires `anthropic-beta: thinking-binding-controls-2026-08-01`. Present
    /// on every such response from a model that supports extended thinking, as `[]`
    /// when there is no entry to report; without the beta, blocks are removed or
    /// left in place all the same but nothing is reported. Removed blocks contribute
    /// nothing to `usage.input_tokens`; blocks left in place count as sent. When
    /// streaming, the array is final in `message_start`; the final `message_delta`
    /// event carries it only when a server-side model fallback happened mid-stream,
    /// in which case it holds the serving model's entries and replaces the one in `message_start`.</para>
    /// </summary>
    public IReadOnlyList<InputTransformation>? InputTransformations
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<ImmutableArray<InputTransformation>>(
                "input_transformations"
            );
        }
        init
        {
            this._rawData.Set<ImmutableArray<InputTransformation>?>(
                "input_transformations",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.ContextManagement?.Validate();
        this.Delta.Validate();
        if (!JsonElement.DeepEquals(this.Type, JsonSerializer.SerializeToElement("message_delta")))
        {
            throw new AnthropicInvalidDataException("Invalid value given for constant");
        }
        this.Usage.Validate();
        foreach (var item in this.InputTransformations ?? [])
        {
            item.Validate();
        }
    }

    public BetaRawMessageDeltaEvent()
    {
        this.Type = JsonSerializer.SerializeToElement("message_delta");
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public BetaRawMessageDeltaEvent(BetaRawMessageDeltaEvent betaRawMessageDeltaEvent)
        : base(betaRawMessageDeltaEvent) { }
#pragma warning restore CS8618

    public BetaRawMessageDeltaEvent(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);

        this.Type = JsonSerializer.SerializeToElement("message_delta");
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    BetaRawMessageDeltaEvent(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BetaRawMessageDeltaEventFromRaw.FromRawUnchecked"/>
    public static BetaRawMessageDeltaEvent FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BetaRawMessageDeltaEventFromRaw : IFromRawJson<BetaRawMessageDeltaEvent>
{
    /// <inheritdoc/>
    public BetaRawMessageDeltaEvent FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => BetaRawMessageDeltaEvent.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Delta, DeltaFromRaw>))]
public sealed record class Delta : JsonModel
{
    /// <summary>
    /// Information about the container used in the request (for the code execution tool)
    /// </summary>
    public required BetaContainer? Container
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<BetaContainer>("container");
        }
        init { this._rawData.Set("container", value); }
    }

    /// <summary>
    /// Structured information about a refusal.
    /// </summary>
    public required BetaRefusalStopDetails? StopDetails
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<BetaRefusalStopDetails>("stop_details");
        }
        init { this._rawData.Set("stop_details", value); }
    }

    public required ApiEnum<string, BetaStopReason>? StopReason
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, BetaStopReason>>("stop_reason");
        }
        init { this._rawData.Set("stop_reason", value); }
    }

    public required string? StopSequence
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("stop_sequence");
        }
        init { this._rawData.Set("stop_sequence", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        this.Container?.Validate();
        this.StopDetails?.Validate();
        this.StopReason?.Validate();
        _ = this.StopSequence;
    }

    public Delta() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Delta(Delta delta)
        : base(delta) { }
#pragma warning restore CS8618

    public Delta(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Delta(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DeltaFromRaw.FromRawUnchecked"/>
    public static Delta FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DeltaFromRaw : IFromRawJson<Delta>
{
    /// <inheritdoc/>
    public Delta FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Delta.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(InputTransformationConverter))]
public record class InputTransformation : ModelBase
{
    public object? Value { get; } = null;

    JsonElement? _element = null;

    public JsonElement Json
    {
        get
        {
            return this._element ??= JsonSerializer.SerializeToElement(
                this.Value,
                ModelBase.SerializerOptions
            );
        }
    }

    public string Path
    {
        get
        {
            return this.Value switch
            {
                BetaThinkingDroppedInputTransformation x => x.Path,
                BetaThinkingMismatchAllowedInputTransformation x => x.Path,
                _ => WrappedJsonSerializer.GetNotNullClassProperty<string>(this.Json, "path"),
            };
        }
    }

    public JsonElement Type
    {
        get
        {
            return this.Value switch
            {
                BetaThinkingDroppedInputTransformation x => x.Type,
                BetaThinkingMismatchAllowedInputTransformation x => x.Type,
                _ => WrappedJsonSerializer.GetNotNullStructProperty<JsonElement>(this.Json, "type"),
            };
        }
    }

    public InputTransformation(
        BetaThinkingDroppedInputTransformation value,
        JsonElement? element = null
    )
    {
        this.Value = value;
        this._element = element;
    }

    public InputTransformation(
        BetaThinkingMismatchAllowedInputTransformation value,
        JsonElement? element = null
    )
    {
        this.Value = value;
        this._element = element;
    }

    public InputTransformation(JsonElement element)
    {
        this._element = element;
    }

    /// <summary>
    /// Returns true and sets the <c>out</c> parameter if the instance was constructed with a variant of
    /// type <see cref="BetaThinkingDroppedInputTransformation"/>.
    ///
    /// <para>Consider using <see cref="Switch"/> or <see cref="Match"/> if you need to handle every variant.</para>
    ///
    /// <example>
    /// <code>
    /// if (instance.TryPickBetaThinkingDropped(out var value)) {
    ///     // `value` is of type `BetaThinkingDroppedInputTransformation`
    ///     Console.WriteLine(value);
    /// }
    /// </code>
    /// </example>
    /// </summary>
    public bool TryPickBetaThinkingDropped(
        [NotNullWhen(true)] out BetaThinkingDroppedInputTransformation? value
    )
    {
        value = this.Value as BetaThinkingDroppedInputTransformation;
        return value != null;
    }

    /// <summary>
    /// Returns true and sets the <c>out</c> parameter if the instance was constructed with a variant of
    /// type <see cref="BetaThinkingMismatchAllowedInputTransformation"/>.
    ///
    /// <para>Consider using <see cref="Switch"/> or <see cref="Match"/> if you need to handle every variant.</para>
    ///
    /// <example>
    /// <code>
    /// if (instance.TryPickBetaThinkingMismatchAllowed(out var value)) {
    ///     // `value` is of type `BetaThinkingMismatchAllowedInputTransformation`
    ///     Console.WriteLine(value);
    /// }
    /// </code>
    /// </example>
    /// </summary>
    public bool TryPickBetaThinkingMismatchAllowed(
        [NotNullWhen(true)] out BetaThinkingMismatchAllowedInputTransformation? value
    )
    {
        value = this.Value as BetaThinkingMismatchAllowedInputTransformation;
        return value != null;
    }

    /// <summary>
    /// Calls the function parameter corresponding to the variant the instance was constructed with.
    ///
    /// <para>Use the <c>TryPick</c> method(s) if you don't need to handle every variant, or <see cref="Match"/>
    /// if you need your function parameters to return something.</para>
    ///
    /// <exception cref="AnthropicInvalidDataException">
    /// Thrown when the instance was constructed with an unknown variant (e.g. deserialized from raw data
    /// that doesn't match any variant's expected shape).
    /// </exception>
    ///
    /// <example>
    /// <code>
    /// instance.Switch(
    ///     (BetaThinkingDroppedInputTransformation value) =&gt; {...},
    ///     (BetaThinkingMismatchAllowedInputTransformation value) =&gt; {...}
    /// );
    /// </code>
    /// </example>
    /// </summary>
    public void Switch(
        System::Action<BetaThinkingDroppedInputTransformation> betaThinkingDropped,
        System::Action<BetaThinkingMismatchAllowedInputTransformation> betaThinkingMismatchAllowed
    )
    {
        switch (this.Value)
        {
            case BetaThinkingDroppedInputTransformation value:
                betaThinkingDropped(value);
                break;
            case BetaThinkingMismatchAllowedInputTransformation value:
                betaThinkingMismatchAllowed(value);
                break;
            default:
                throw new AnthropicInvalidDataException(
                    "Data did not match any variant of InputTransformation"
                );
        }
    }

    /// <summary>
    /// Calls the function parameter corresponding to the variant the instance was constructed with and
    /// returns its result.
    ///
    /// <para>Use the <c>TryPick</c> method(s) if you don't need to handle every variant, or <see cref="Switch"/>
    /// if you don't need your function parameters to return a value.</para>
    ///
    /// <exception cref="AnthropicInvalidDataException">
    /// Thrown when the instance was constructed with an unknown variant (e.g. deserialized from raw data
    /// that doesn't match any variant's expected shape).
    /// </exception>
    ///
    /// <example>
    /// <code>
    /// var result = instance.Match(
    ///     (BetaThinkingDroppedInputTransformation value) =&gt; {...},
    ///     (BetaThinkingMismatchAllowedInputTransformation value) =&gt; {...}
    /// );
    /// </code>
    /// </example>
    /// </summary>
    public T Match<T>(
        System::Func<BetaThinkingDroppedInputTransformation, T> betaThinkingDropped,
        System::Func<BetaThinkingMismatchAllowedInputTransformation, T> betaThinkingMismatchAllowed
    )
    {
        return this.Value switch
        {
            BetaThinkingDroppedInputTransformation value => betaThinkingDropped(value),
            BetaThinkingMismatchAllowedInputTransformation value => betaThinkingMismatchAllowed(
                value
            ),
            _ => throw new AnthropicInvalidDataException(
                "Data did not match any variant of InputTransformation"
            ),
        };
    }

    public static implicit operator InputTransformation(
        BetaThinkingDroppedInputTransformation value
    ) => new(value);

    public static implicit operator InputTransformation(
        BetaThinkingMismatchAllowedInputTransformation value
    ) => new(value);

    /// <summary>
    /// Validates that the instance was constructed with a known variant and that this variant is valid
    /// (based on its own <c>Validate</c> method).
    ///
    /// <para>This is useful for instances constructed from raw JSON data (e.g. deserialized from an API response).</para>
    ///
    /// <exception cref="AnthropicInvalidDataException">
    /// Thrown when the instance does not pass validation.
    /// </exception>
    /// </summary>
    public override void Validate()
    {
        if (this.Value == null)
        {
            throw new AnthropicInvalidDataException(
                "Data did not match any variant of InputTransformation"
            );
        }
        this.Switch(
            (betaThinkingDropped) => betaThinkingDropped.Validate(),
            (betaThinkingMismatchAllowed) => betaThinkingMismatchAllowed.Validate()
        );
    }

    public virtual bool Equals(InputTransformation? other) =>
        other != null
        && this.VariantIndex() == other.VariantIndex()
        && JsonElement.DeepEquals(this.Json, other.Json);

    public override int GetHashCode()
    {
        return 0;
    }

    public override string ToString() =>
        JsonSerializer.Serialize(
            FriendlyJsonPrinter.PrintValue(this.Json),
            ModelBase.ToStringSerializerOptions
        );

    int VariantIndex()
    {
        return this.Value switch
        {
            BetaThinkingDroppedInputTransformation _ => 0,
            BetaThinkingMismatchAllowedInputTransformation _ => 1,
            _ => -1,
        };
    }
}

sealed class InputTransformationConverter : JsonConverter<InputTransformation>
{
    public override InputTransformation? Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        var element = JsonSerializer.Deserialize<JsonElement>(ref reader, options);
        string? type;
        try
        {
            type = element.GetProperty("type").GetString();
        }
        catch
        {
            type = null;
        }

        switch (type)
        {
            case "thinking_dropped":
            {
                try
                {
                    var deserialized =
                        JsonSerializer.Deserialize<BetaThinkingDroppedInputTransformation>(
                            element,
                            options
                        );
                    if (deserialized != null)
                    {
                        return new(deserialized, element);
                    }
                }
                catch (JsonException)
                {
                    // ignore
                }

                return new(element);
            }
            case "thinking_mismatch_allowed":
            {
                try
                {
                    var deserialized =
                        JsonSerializer.Deserialize<BetaThinkingMismatchAllowedInputTransformation>(
                            element,
                            options
                        );
                    if (deserialized != null)
                    {
                        return new(deserialized, element);
                    }
                }
                catch (JsonException)
                {
                    // ignore
                }

                return new(element);
            }
            default:
            {
                return new InputTransformation(element);
            }
        }
    }

    public override void Write(
        Utf8JsonWriter writer,
        InputTransformation value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(writer, value.Json, options);
    }
}
