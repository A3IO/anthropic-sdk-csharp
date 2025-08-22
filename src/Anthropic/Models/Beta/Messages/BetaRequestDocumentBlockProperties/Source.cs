using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using SourceVariants = Anthropic.Models.Beta.Messages.BetaRequestDocumentBlockProperties.SourceVariants;

namespace Anthropic.Models.Beta.Messages.BetaRequestDocumentBlockProperties;

[JsonConverter(typeof(SourceConverter))]
public abstract record class Source
{
    internal Source() { }

    public static implicit operator Source(BetaBase64PDFSource value) =>
        new SourceVariants::BetaBase64PDFSource(value);

    public static implicit operator Source(BetaPlainTextSource value) =>
        new SourceVariants::BetaPlainTextSource(value);

    public static implicit operator Source(BetaContentBlockSource value) =>
        new SourceVariants::BetaContentBlockSource(value);

    public static implicit operator Source(BetaURLPDFSource value) =>
        new SourceVariants::BetaURLPDFSource(value);

    public static implicit operator Source(BetaFileDocumentSource value) =>
        new SourceVariants::BetaFileDocumentSource(value);

    public bool TryPickBetaBase64PDFSource([NotNullWhen(true)] out BetaBase64PDFSource? value)
    {
        value = (this as SourceVariants::BetaBase64PDFSource)?.Value;
        return value != null;
    }

    public bool TryPickBetaPlainTextSource([NotNullWhen(true)] out BetaPlainTextSource? value)
    {
        value = (this as SourceVariants::BetaPlainTextSource)?.Value;
        return value != null;
    }

    public bool TryPickBetaContentBlockSource([NotNullWhen(true)] out BetaContentBlockSource? value)
    {
        value = (this as SourceVariants::BetaContentBlockSource)?.Value;
        return value != null;
    }

    public bool TryPickBetaURLPDFSource([NotNullWhen(true)] out BetaURLPDFSource? value)
    {
        value = (this as SourceVariants::BetaURLPDFSource)?.Value;
        return value != null;
    }

    public bool TryPickBetaFileDocumentSource([NotNullWhen(true)] out BetaFileDocumentSource? value)
    {
        value = (this as SourceVariants::BetaFileDocumentSource)?.Value;
        return value != null;
    }

    public void Switch(
        Action<SourceVariants::BetaBase64PDFSource> betaBase64PDFSource,
        Action<SourceVariants::BetaPlainTextSource> betaPlainTextSource,
        Action<SourceVariants::BetaContentBlockSource> betaContentBlockSource,
        Action<SourceVariants::BetaURLPDFSource> betaUrlpdfSource,
        Action<SourceVariants::BetaFileDocumentSource> betaFileDocumentSource
    )
    {
        switch (this)
        {
            case SourceVariants::BetaBase64PDFSource inner:
                betaBase64PDFSource(inner);
                break;
            case SourceVariants::BetaPlainTextSource inner:
                betaPlainTextSource(inner);
                break;
            case SourceVariants::BetaContentBlockSource inner:
                betaContentBlockSource(inner);
                break;
            case SourceVariants::BetaURLPDFSource inner:
                betaUrlpdfSource(inner);
                break;
            case SourceVariants::BetaFileDocumentSource inner:
                betaFileDocumentSource(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<SourceVariants::BetaBase64PDFSource, T> betaBase64PDFSource,
        Func<SourceVariants::BetaPlainTextSource, T> betaPlainTextSource,
        Func<SourceVariants::BetaContentBlockSource, T> betaContentBlockSource,
        Func<SourceVariants::BetaURLPDFSource, T> betaUrlpdfSource,
        Func<SourceVariants::BetaFileDocumentSource, T> betaFileDocumentSource
    )
    {
        return this switch
        {
            SourceVariants::BetaBase64PDFSource inner => betaBase64PDFSource(inner),
            SourceVariants::BetaPlainTextSource inner => betaPlainTextSource(inner),
            SourceVariants::BetaContentBlockSource inner => betaContentBlockSource(inner),
            SourceVariants::BetaURLPDFSource inner => betaUrlpdfSource(inner),
            SourceVariants::BetaFileDocumentSource inner => betaFileDocumentSource(inner),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class SourceConverter : JsonConverter<Source>
{
    public override Source? Read(
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
            case "base64":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaBase64PDFSource>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new SourceVariants::BetaBase64PDFSource(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "text":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaPlainTextSource>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new SourceVariants::BetaPlainTextSource(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "content":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaContentBlockSource>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new SourceVariants::BetaContentBlockSource(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "url":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaURLPDFSource>(json, options);
                    if (deserialized != null)
                    {
                        return new SourceVariants::BetaURLPDFSource(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "file":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaFileDocumentSource>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new SourceVariants::BetaFileDocumentSource(deserialized);
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

    public override void Write(Utf8JsonWriter writer, Source value, JsonSerializerOptions options)
    {
        object variant = value switch
        {
            SourceVariants::BetaBase64PDFSource(var betaBase64PDFSource) => betaBase64PDFSource,
            SourceVariants::BetaPlainTextSource(var betaPlainTextSource) => betaPlainTextSource,
            SourceVariants::BetaContentBlockSource(var betaContentBlockSource) =>
                betaContentBlockSource,
            SourceVariants::BetaURLPDFSource(var betaUrlpdfSource) => betaUrlpdfSource,
            SourceVariants::BetaFileDocumentSource(var betaFileDocumentSource) =>
                betaFileDocumentSource,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
