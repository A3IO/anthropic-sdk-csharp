using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using SourceVariants = Anthropic.Models.Messages.DocumentBlockParamProperties.SourceVariants;

namespace Anthropic.Models.Messages.DocumentBlockParamProperties;

[JsonConverter(typeof(SourceConverter))]
public abstract record class Source
{
    internal Source() { }

    public static implicit operator Source(Base64PDFSource value) =>
        new SourceVariants::Base64PDFSource(value);

    public static implicit operator Source(PlainTextSource value) =>
        new SourceVariants::PlainTextSource(value);

    public static implicit operator Source(ContentBlockSource value) =>
        new SourceVariants::ContentBlockSource(value);

    public static implicit operator Source(URLPDFSource value) =>
        new SourceVariants::URLPDFSource(value);

    public bool TryPickBase64PDFSource([NotNullWhen(true)] out Base64PDFSource? value)
    {
        value = (this as SourceVariants::Base64PDFSource)?.Value;
        return value != null;
    }

    public bool TryPickPlainTextSource([NotNullWhen(true)] out PlainTextSource? value)
    {
        value = (this as SourceVariants::PlainTextSource)?.Value;
        return value != null;
    }

    public bool TryPickContentBlockSource([NotNullWhen(true)] out ContentBlockSource? value)
    {
        value = (this as SourceVariants::ContentBlockSource)?.Value;
        return value != null;
    }

    public bool TryPickURLPDFSource([NotNullWhen(true)] out URLPDFSource? value)
    {
        value = (this as SourceVariants::URLPDFSource)?.Value;
        return value != null;
    }

    public void Switch(
        Action<SourceVariants::Base64PDFSource> base64PDFSource,
        Action<SourceVariants::PlainTextSource> plainTextSource,
        Action<SourceVariants::ContentBlockSource> contentBlockSource,
        Action<SourceVariants::URLPDFSource> urlpdfSource
    )
    {
        switch (this)
        {
            case SourceVariants::Base64PDFSource inner:
                base64PDFSource(inner);
                break;
            case SourceVariants::PlainTextSource inner:
                plainTextSource(inner);
                break;
            case SourceVariants::ContentBlockSource inner:
                contentBlockSource(inner);
                break;
            case SourceVariants::URLPDFSource inner:
                urlpdfSource(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<SourceVariants::Base64PDFSource, T> base64PDFSource,
        Func<SourceVariants::PlainTextSource, T> plainTextSource,
        Func<SourceVariants::ContentBlockSource, T> contentBlockSource,
        Func<SourceVariants::URLPDFSource, T> urlpdfSource
    )
    {
        return this switch
        {
            SourceVariants::Base64PDFSource inner => base64PDFSource(inner),
            SourceVariants::PlainTextSource inner => plainTextSource(inner),
            SourceVariants::ContentBlockSource inner => contentBlockSource(inner),
            SourceVariants::URLPDFSource inner => urlpdfSource(inner),
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
                    var deserialized = JsonSerializer.Deserialize<Base64PDFSource>(json, options);
                    if (deserialized != null)
                    {
                        return new SourceVariants::Base64PDFSource(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<PlainTextSource>(json, options);
                    if (deserialized != null)
                    {
                        return new SourceVariants::PlainTextSource(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<ContentBlockSource>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new SourceVariants::ContentBlockSource(deserialized);
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
                    var deserialized = JsonSerializer.Deserialize<URLPDFSource>(json, options);
                    if (deserialized != null)
                    {
                        return new SourceVariants::URLPDFSource(deserialized);
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
            SourceVariants::Base64PDFSource(var base64PDFSource) => base64PDFSource,
            SourceVariants::PlainTextSource(var plainTextSource) => plainTextSource,
            SourceVariants::ContentBlockSource(var contentBlockSource) => contentBlockSource,
            SourceVariants::URLPDFSource(var urlpdfSource) => urlpdfSource,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
