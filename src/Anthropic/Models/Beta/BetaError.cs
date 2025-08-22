using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using BetaErrorVariants = Anthropic.Models.Beta.BetaErrorVariants;

namespace Anthropic.Models.Beta;

[JsonConverter(typeof(BetaErrorConverter))]
public abstract record class BetaError
{
    internal BetaError() { }

    public static implicit operator BetaError(BetaInvalidRequestError value) =>
        new BetaErrorVariants::BetaInvalidRequestError(value);

    public static implicit operator BetaError(BetaAuthenticationError value) =>
        new BetaErrorVariants::BetaAuthenticationError(value);

    public static implicit operator BetaError(BetaBillingError value) =>
        new BetaErrorVariants::BetaBillingError(value);

    public static implicit operator BetaError(BetaPermissionError value) =>
        new BetaErrorVariants::BetaPermissionError(value);

    public static implicit operator BetaError(BetaNotFoundError value) =>
        new BetaErrorVariants::BetaNotFoundError(value);

    public static implicit operator BetaError(BetaRateLimitError value) =>
        new BetaErrorVariants::BetaRateLimitError(value);

    public static implicit operator BetaError(BetaGatewayTimeoutError value) =>
        new BetaErrorVariants::BetaGatewayTimeoutError(value);

    public static implicit operator BetaError(BetaAPIError value) =>
        new BetaErrorVariants::BetaAPIError(value);

    public static implicit operator BetaError(BetaOverloadedError value) =>
        new BetaErrorVariants::BetaOverloadedError(value);

    public bool TryPickBetaInvalidRequestError(
        [NotNullWhen(true)] out BetaInvalidRequestError? value
    )
    {
        value = (this as BetaErrorVariants::BetaInvalidRequestError)?.Value;
        return value != null;
    }

    public bool TryPickBetaAuthenticationError(
        [NotNullWhen(true)] out BetaAuthenticationError? value
    )
    {
        value = (this as BetaErrorVariants::BetaAuthenticationError)?.Value;
        return value != null;
    }

    public bool TryPickBetaBillingError([NotNullWhen(true)] out BetaBillingError? value)
    {
        value = (this as BetaErrorVariants::BetaBillingError)?.Value;
        return value != null;
    }

    public bool TryPickBetaPermissionError([NotNullWhen(true)] out BetaPermissionError? value)
    {
        value = (this as BetaErrorVariants::BetaPermissionError)?.Value;
        return value != null;
    }

    public bool TryPickBetaNotFoundError([NotNullWhen(true)] out BetaNotFoundError? value)
    {
        value = (this as BetaErrorVariants::BetaNotFoundError)?.Value;
        return value != null;
    }

    public bool TryPickBetaRateLimitError([NotNullWhen(true)] out BetaRateLimitError? value)
    {
        value = (this as BetaErrorVariants::BetaRateLimitError)?.Value;
        return value != null;
    }

    public bool TryPickBetaGatewayTimeoutError(
        [NotNullWhen(true)] out BetaGatewayTimeoutError? value
    )
    {
        value = (this as BetaErrorVariants::BetaGatewayTimeoutError)?.Value;
        return value != null;
    }

    public bool TryPickBetaAPIError([NotNullWhen(true)] out BetaAPIError? value)
    {
        value = (this as BetaErrorVariants::BetaAPIError)?.Value;
        return value != null;
    }

    public bool TryPickBetaOverloadedError([NotNullWhen(true)] out BetaOverloadedError? value)
    {
        value = (this as BetaErrorVariants::BetaOverloadedError)?.Value;
        return value != null;
    }

    public void Switch(
        Action<BetaErrorVariants::BetaInvalidRequestError> betaInvalidRequestError,
        Action<BetaErrorVariants::BetaAuthenticationError> betaAuthenticationError,
        Action<BetaErrorVariants::BetaBillingError> betaBillingError,
        Action<BetaErrorVariants::BetaPermissionError> betaPermissionError,
        Action<BetaErrorVariants::BetaNotFoundError> betaNotFoundError,
        Action<BetaErrorVariants::BetaRateLimitError> betaRateLimitError,
        Action<BetaErrorVariants::BetaGatewayTimeoutError> betaGatewayTimeoutError,
        Action<BetaErrorVariants::BetaAPIError> betaAPIError,
        Action<BetaErrorVariants::BetaOverloadedError> betaOverloadedError
    )
    {
        switch (this)
        {
            case BetaErrorVariants::BetaInvalidRequestError inner:
                betaInvalidRequestError(inner);
                break;
            case BetaErrorVariants::BetaAuthenticationError inner:
                betaAuthenticationError(inner);
                break;
            case BetaErrorVariants::BetaBillingError inner:
                betaBillingError(inner);
                break;
            case BetaErrorVariants::BetaPermissionError inner:
                betaPermissionError(inner);
                break;
            case BetaErrorVariants::BetaNotFoundError inner:
                betaNotFoundError(inner);
                break;
            case BetaErrorVariants::BetaRateLimitError inner:
                betaRateLimitError(inner);
                break;
            case BetaErrorVariants::BetaGatewayTimeoutError inner:
                betaGatewayTimeoutError(inner);
                break;
            case BetaErrorVariants::BetaAPIError inner:
                betaAPIError(inner);
                break;
            case BetaErrorVariants::BetaOverloadedError inner:
                betaOverloadedError(inner);
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    public T Match<T>(
        Func<BetaErrorVariants::BetaInvalidRequestError, T> betaInvalidRequestError,
        Func<BetaErrorVariants::BetaAuthenticationError, T> betaAuthenticationError,
        Func<BetaErrorVariants::BetaBillingError, T> betaBillingError,
        Func<BetaErrorVariants::BetaPermissionError, T> betaPermissionError,
        Func<BetaErrorVariants::BetaNotFoundError, T> betaNotFoundError,
        Func<BetaErrorVariants::BetaRateLimitError, T> betaRateLimitError,
        Func<BetaErrorVariants::BetaGatewayTimeoutError, T> betaGatewayTimeoutError,
        Func<BetaErrorVariants::BetaAPIError, T> betaAPIError,
        Func<BetaErrorVariants::BetaOverloadedError, T> betaOverloadedError
    )
    {
        return this switch
        {
            BetaErrorVariants::BetaInvalidRequestError inner => betaInvalidRequestError(inner),
            BetaErrorVariants::BetaAuthenticationError inner => betaAuthenticationError(inner),
            BetaErrorVariants::BetaBillingError inner => betaBillingError(inner),
            BetaErrorVariants::BetaPermissionError inner => betaPermissionError(inner),
            BetaErrorVariants::BetaNotFoundError inner => betaNotFoundError(inner),
            BetaErrorVariants::BetaRateLimitError inner => betaRateLimitError(inner),
            BetaErrorVariants::BetaGatewayTimeoutError inner => betaGatewayTimeoutError(inner),
            BetaErrorVariants::BetaAPIError inner => betaAPIError(inner),
            BetaErrorVariants::BetaOverloadedError inner => betaOverloadedError(inner),
            _ => throw new InvalidOperationException(),
        };
    }

    public abstract void Validate();
}

sealed class BetaErrorConverter : JsonConverter<BetaError>
{
    public override BetaError? Read(
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
            case "invalid_request_error":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaInvalidRequestError>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaErrorVariants::BetaInvalidRequestError(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "authentication_error":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaAuthenticationError>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaErrorVariants::BetaAuthenticationError(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "billing_error":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaBillingError>(json, options);
                    if (deserialized != null)
                    {
                        return new BetaErrorVariants::BetaBillingError(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "permission_error":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaPermissionError>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaErrorVariants::BetaPermissionError(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "not_found_error":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaNotFoundError>(json, options);
                    if (deserialized != null)
                    {
                        return new BetaErrorVariants::BetaNotFoundError(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "rate_limit_error":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaRateLimitError>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaErrorVariants::BetaRateLimitError(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "timeout_error":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaGatewayTimeoutError>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaErrorVariants::BetaGatewayTimeoutError(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "api_error":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaAPIError>(json, options);
                    if (deserialized != null)
                    {
                        return new BetaErrorVariants::BetaAPIError(deserialized);
                    }
                }
                catch (JsonException e)
                {
                    exceptions.Add(e);
                }

                throw new AggregateException(exceptions);
            }
            case "overloaded_error":
            {
                List<JsonException> exceptions = [];

                try
                {
                    var deserialized = JsonSerializer.Deserialize<BetaOverloadedError>(
                        json,
                        options
                    );
                    if (deserialized != null)
                    {
                        return new BetaErrorVariants::BetaOverloadedError(deserialized);
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
        BetaError value,
        JsonSerializerOptions options
    )
    {
        object variant = value switch
        {
            BetaErrorVariants::BetaInvalidRequestError(var betaInvalidRequestError) =>
                betaInvalidRequestError,
            BetaErrorVariants::BetaAuthenticationError(var betaAuthenticationError) =>
                betaAuthenticationError,
            BetaErrorVariants::BetaBillingError(var betaBillingError) => betaBillingError,
            BetaErrorVariants::BetaPermissionError(var betaPermissionError) => betaPermissionError,
            BetaErrorVariants::BetaNotFoundError(var betaNotFoundError) => betaNotFoundError,
            BetaErrorVariants::BetaRateLimitError(var betaRateLimitError) => betaRateLimitError,
            BetaErrorVariants::BetaGatewayTimeoutError(var betaGatewayTimeoutError) =>
                betaGatewayTimeoutError,
            BetaErrorVariants::BetaAPIError(var betaAPIError) => betaAPIError,
            BetaErrorVariants::BetaOverloadedError(var betaOverloadedError) => betaOverloadedError,
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        };
        JsonSerializer.Serialize(writer, variant, options);
    }
}
