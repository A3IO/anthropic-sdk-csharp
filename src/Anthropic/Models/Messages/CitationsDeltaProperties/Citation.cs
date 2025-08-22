using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using CitationVariants = Anthropic.Models.Messages.CitationsDeltaProperties.CitationVariants;

namespace Anthropic.Models.Messages.CitationsDeltaProperties;

[JsonConverter(typeof(CitationConverter))]
public abstract record class Citation
{
    internal Citation() { }

    public static implicit operator Citation(CitationCharLocation value) =>
        new CitationVariants::CitationCharLocation(value);

    public static implicit operator Citation(CitationPageLocation value) =>
        new CitationVariants::CitationPageLocation(value);

    public static implicit operator Citation(CitationContentBlockLocation value) =>
        new CitationVariants::CitationContentBlockLocation(value);

    public static implicit operator Citation(CitationsWebSearchResultLocation value) =>
        new CitationVariants::CitationsWebSearchResultLocation(value);

    public static implicit operator Citation(CitationsSearchResultLocation value) =>
        new CitationVariants::CitationsSearchResultLocation(value);

    public bool TryPickCitationCharLocation([NotNullWhen(true)] out CitationCharLocation? value)
    {
        value = (this as CitationVariants::CitationCharLocation)?.Value;
        return value != null;
    }

    public bool TryPickCitationPageLocation([NotNullWhen(true)] out CitationPageLocation? value)
    {
        value = (this as CitationVariants::CitationPageLocation)?.Value;
        return value != null;
    }

    public bool TryPickCitationContentBlockLocation(
        [NotNullWhen(true)] out CitationContentBlockLocation? value
    )
    {
        value = (this as CitationVariants::CitationContentBlockLocation)?.Value;
        return value != null;
    }

    public bool TryPickCitationsWebSearchResultLocation(
        [NotNullWhen(true)] out CitationsWebSearchResultLocation? value
    )
    {
        value = (this as CitationVariants::CitationsWebSearchResultLocation)?.Value;
        return value != null;
    }

    public bool TryPickCitationsSearchResultLocation(
        [NotNullWhen(true)] out CitationsSearchResultLocation? value
    )
    {
        value = (this as CitationVariants::CitationsSearchResultLocation)?.Value;
        return value != null;
    }

    public void Switch(
        Action<CitationVariants::CitationCharLocation> citationCharLocation,
        Action<CitationVariants::CitationPageLocation> citationPageLocation,
        Action<CitationVariants::CitationContentBlockLocation> citationContentBlockLocation,
        Action<CitationVariants::CitationsWebSearchResultLocation> citationsWebSearchResultLocation,
        Action<CitationVariants::CitationsSearchResultLocation> citationsSearchResultLocation
    )
    {
        switch (this)
        {
            case CitationVariants::CitationCharLocation inner:
                citationCharLocation(inner);
                break;
            case CitationVariants::CitationPageLocation inner:
                citationPageLocation(inner);
                break;
            case CitationVariants::CitationContentBlockLocation inner:
                citationContentBlockLocation(inner);
                break;
            case CitationVariants::CitationsWebSearchResultLocation inner:
                citationsWebSearchResultLocation(inner);
                break;
            case CitationVariants::CitationsSearchResultLocation inner:
                citationsSearchResultLocation(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<CitationVariants::CitationCharLocation, T> citationCharLocation,
        Func<CitationVariants::CitationPageLocation, T> citationPageLocation,
        Func<CitationVariants::CitationContentBlockLocation, T> citationContentBlockLocation,
        Func<
            CitationVariants::CitationsWebSearchResultLocation,
            T
        > citationsWebSearchResultLocation,
        Func<CitationVariants::CitationsSearchResultLocation, T> citationsSearchResultLocation
    )
    {
        return this switch
        {
            CitationVariants::CitationCharLocation inner => citationCharLocation(inner),
            CitationVariants::CitationPageLocation inner => citationPageLocation(inner),
            CitationVariants::CitationContentBlockLocation inner => citationContentBlockLocation(
                inner
            ),
            CitationVariants::CitationsWebSearchResultLocation inner =>
                citationsWebSearchResultLocation(inner),
            CitationVariants::CitationsSearchResultLocation inner => citationsSearchResultLocation(
                inner
            ),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class CitationConverter : JsonConverter<Citation>
{
    public override Citation? Read(
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
                    var deserialized = JsonSerializer.Deserialize<CitationCharLocation>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new CitationVariants::CitationCharLocation(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<CitationPageLocation>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new CitationVariants::CitationPageLocation(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<CitationContentBlockLocation>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new CitationVariants::CitationContentBlockLocation(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<CitationsWebSearchResultLocation>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new CitationVariants::CitationsWebSearchResultLocation(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<CitationsSearchResultLocation>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new CitationVariants::CitationsSearchResultLocation(deserialized);
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

    public override void Write(Utf8JsonWriter writer, Citation value, JsonSerializerOptions options)
    {
        object variant = value switch
        {
            CitationVariants::CitationCharLocation(var citationCharLocation) =>
                citationCharLocation,
            CitationVariants::CitationPageLocation(var citationPageLocation) =>
                citationPageLocation,
            CitationVariants::CitationContentBlockLocation(var citationContentBlockLocation) =>
                citationContentBlockLocation,
            CitationVariants::CitationsWebSearchResultLocation(
                var citationsWebSearchResultLocation
            ) => citationsWebSearchResultLocation,
            CitationVariants::CitationsSearchResultLocation(var citationsSearchResultLocation) =>
                citationsSearchResultLocation,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
