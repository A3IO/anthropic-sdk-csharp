using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using BetaTextCitationParamVariants = Anthropic.Models.Beta.Messages.BetaTextCitationParamVariants;

namespace Anthropic.Models.Beta.Messages;

[JsonConverter(typeof(BetaTextCitationParamConverter))]
public abstract record class BetaTextCitationParam
{
    internal BetaTextCitationParam() { }

    public static implicit operator BetaTextCitationParam(BetaCitationCharLocationParam value) =>
        new BetaTextCitationParamVariants::BetaCitationCharLocationParam(value);

    public static implicit operator BetaTextCitationParam(BetaCitationPageLocationParam value) =>
        new BetaTextCitationParamVariants::BetaCitationPageLocationParam(value);

    public static implicit operator BetaTextCitationParam(
        BetaCitationContentBlockLocationParam value
    ) => new BetaTextCitationParamVariants::BetaCitationContentBlockLocationParam(value);

    public static implicit operator BetaTextCitationParam(
        BetaCitationWebSearchResultLocationParam value
    ) => new BetaTextCitationParamVariants::BetaCitationWebSearchResultLocationParam(value);

    public static implicit operator BetaTextCitationParam(
        BetaCitationSearchResultLocationParam value
    ) => new BetaTextCitationParamVariants::BetaCitationSearchResultLocationParam(value);

    public bool TryPickBetaCitationCharLocationParam(
        [NotNullWhen(true)] out BetaCitationCharLocationParam? value
    )
    {
        value = (this as BetaTextCitationParamVariants::BetaCitationCharLocationParam)?.Value;
        return value != null;
    }

    public bool TryPickBetaCitationPageLocationParam(
        [NotNullWhen(true)] out BetaCitationPageLocationParam? value
    )
    {
        value = (this as BetaTextCitationParamVariants::BetaCitationPageLocationParam)?.Value;
        return value != null;
    }

    public bool TryPickBetaCitationContentBlockLocationParam(
        [NotNullWhen(true)] out BetaCitationContentBlockLocationParam? value
    )
    {
        value = (
            this as BetaTextCitationParamVariants::BetaCitationContentBlockLocationParam
        )?.Value;
        return value != null;
    }

    public bool TryPickBetaCitationWebSearchResultLocationParam(
        [NotNullWhen(true)] out BetaCitationWebSearchResultLocationParam? value
    )
    {
        value = (
            this as BetaTextCitationParamVariants::BetaCitationWebSearchResultLocationParam
        )?.Value;
        return value != null;
    }

    public bool TryPickBetaCitationSearchResultLocationParam(
        [NotNullWhen(true)] out BetaCitationSearchResultLocationParam? value
    )
    {
        value = (
            this as BetaTextCitationParamVariants::BetaCitationSearchResultLocationParam
        )?.Value;
        return value != null;
    }

    public void Switch(
        Action<BetaTextCitationParamVariants::BetaCitationCharLocationParam> betaCitationCharLocationParam,
        Action<BetaTextCitationParamVariants::BetaCitationPageLocationParam> betaCitationPageLocationParam,
        Action<BetaTextCitationParamVariants::BetaCitationContentBlockLocationParam> betaCitationContentBlockLocationParam,
        Action<BetaTextCitationParamVariants::BetaCitationWebSearchResultLocationParam> betaCitationWebSearchResultLocationParam,
        Action<BetaTextCitationParamVariants::BetaCitationSearchResultLocationParam> betaCitationSearchResultLocationParam
    )
    {
        switch (this)
        {
            case BetaTextCitationParamVariants::BetaCitationCharLocationParam inner:
                betaCitationCharLocationParam(inner);
                break;
            case BetaTextCitationParamVariants::BetaCitationPageLocationParam inner:
                betaCitationPageLocationParam(inner);
                break;
            case BetaTextCitationParamVariants::BetaCitationContentBlockLocationParam inner:
                betaCitationContentBlockLocationParam(inner);
                break;
            case BetaTextCitationParamVariants::BetaCitationWebSearchResultLocationParam inner:
                betaCitationWebSearchResultLocationParam(inner);
                break;
            case BetaTextCitationParamVariants::BetaCitationSearchResultLocationParam inner:
                betaCitationSearchResultLocationParam(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<
            BetaTextCitationParamVariants::BetaCitationCharLocationParam,
            T
        > betaCitationCharLocationParam,
        Func<
            BetaTextCitationParamVariants::BetaCitationPageLocationParam,
            T
        > betaCitationPageLocationParam,
        Func<
            BetaTextCitationParamVariants::BetaCitationContentBlockLocationParam,
            T
        > betaCitationContentBlockLocationParam,
        Func<
            BetaTextCitationParamVariants::BetaCitationWebSearchResultLocationParam,
            T
        > betaCitationWebSearchResultLocationParam,
        Func<
            BetaTextCitationParamVariants::BetaCitationSearchResultLocationParam,
            T
        > betaCitationSearchResultLocationParam
    )
    {
        return this switch
        {
            BetaTextCitationParamVariants::BetaCitationCharLocationParam inner =>
                betaCitationCharLocationParam(inner),
            BetaTextCitationParamVariants::BetaCitationPageLocationParam inner =>
                betaCitationPageLocationParam(inner),
            BetaTextCitationParamVariants::BetaCitationContentBlockLocationParam inner =>
                betaCitationContentBlockLocationParam(inner),
            BetaTextCitationParamVariants::BetaCitationWebSearchResultLocationParam inner =>
                betaCitationWebSearchResultLocationParam(inner),
            BetaTextCitationParamVariants::BetaCitationSearchResultLocationParam inner =>
                betaCitationSearchResultLocationParam(inner),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class BetaTextCitationParamConverter : JsonConverter<BetaTextCitationParam>
{
    public override BetaTextCitationParam? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        var json = JsonSerializer.Deserialize<JsonElement>(ref reader, options);
        string? type;
        try
        {
            type = json.GetProperty("type").GetString();
        }
        catch
        {
            type = null;
        }

        switch (type)
        {
            case "char_location":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaCitationCharLocationParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaTextCitationParamVariants::BetaCitationCharLocationParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "page_location":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaCitationPageLocationParam>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaTextCitationParamVariants::BetaCitationPageLocationParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "content_block_location":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized =
                        JsonSerializer.Deserialize<BetaCitationContentBlockLocationParam>(
                            json,
                            options
                        );
                    if (deserialized != null)
                    {
                        return new BetaTextCitationParamVariants::BetaCitationContentBlockLocationParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "web_search_result_location":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized =
                        JsonSerializer.Deserialize<BetaCitationWebSearchResultLocationParam>(
                            json,
                            options
                        );
                    if (deserialized != null)
                    {
                        return new BetaTextCitationParamVariants::BetaCitationWebSearchResultLocationParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "search_result_location":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized =
                        JsonSerializer.Deserialize<BetaCitationSearchResultLocationParam>(
                            json,
                            options
                        );
                    if (deserialized != null)
                    {
                        return new BetaTextCitationParamVariants::BetaCitationSearchResultLocationParam(
                            deserialized
                        );
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            default:
            {
                throw new Exception();
            }
        }
    }

    public override void Write(
        Utf8JsonWriter writer,
        BetaTextCitationParam value,
        JsonSerializerOptions options
    )
    {
        object variant = value switch
        {
            BetaTextCitationParamVariants::BetaCitationCharLocationParam(
                var betaCitationCharLocationParam
            ) => betaCitationCharLocationParam,
            BetaTextCitationParamVariants::BetaCitationPageLocationParam(
                var betaCitationPageLocationParam
            ) => betaCitationPageLocationParam,
            BetaTextCitationParamVariants::BetaCitationContentBlockLocationParam(
                var betaCitationContentBlockLocationParam
            ) => betaCitationContentBlockLocationParam,
            BetaTextCitationParamVariants::BetaCitationWebSearchResultLocationParam(
                var betaCitationWebSearchResultLocationParam
            ) => betaCitationWebSearchResultLocationParam,
            BetaTextCitationParamVariants::BetaCitationSearchResultLocationParam(
                var betaCitationSearchResultLocationParam
            ) => betaCitationSearchResultLocationParam,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
