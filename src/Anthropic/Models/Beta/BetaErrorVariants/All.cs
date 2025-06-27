using Anthropic = Anthropic;
using Beta = Anthropic.Models.Beta;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.BetaErrorVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaInvalidRequestError, Beta::BetaInvalidRequestError>)
)]
public sealed record class BetaInvalidRequestError(Beta::BetaInvalidRequestError Value)
    : Beta::BetaError,
        Anthropic::IVariant<BetaInvalidRequestError, Beta::BetaInvalidRequestError>
{
    public static BetaInvalidRequestError From(Beta::BetaInvalidRequestError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaAuthenticationError, Beta::BetaAuthenticationError>)
)]
public sealed record class BetaAuthenticationError(Beta::BetaAuthenticationError Value)
    : Beta::BetaError,
        Anthropic::IVariant<BetaAuthenticationError, Beta::BetaAuthenticationError>
{
    public static BetaAuthenticationError From(Beta::BetaAuthenticationError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaBillingError, Beta::BetaBillingError>)
)]
public sealed record class BetaBillingError(Beta::BetaBillingError Value)
    : Beta::BetaError,
        Anthropic::IVariant<BetaBillingError, Beta::BetaBillingError>
{
    public static BetaBillingError From(Beta::BetaBillingError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaPermissionError, Beta::BetaPermissionError>)
)]
public sealed record class BetaPermissionError(Beta::BetaPermissionError Value)
    : Beta::BetaError,
        Anthropic::IVariant<BetaPermissionError, Beta::BetaPermissionError>
{
    public static BetaPermissionError From(Beta::BetaPermissionError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaNotFoundError, Beta::BetaNotFoundError>)
)]
public sealed record class BetaNotFoundError(Beta::BetaNotFoundError Value)
    : Beta::BetaError,
        Anthropic::IVariant<BetaNotFoundError, Beta::BetaNotFoundError>
{
    public static BetaNotFoundError From(Beta::BetaNotFoundError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaRateLimitError, Beta::BetaRateLimitError>)
)]
public sealed record class BetaRateLimitError(Beta::BetaRateLimitError Value)
    : Beta::BetaError,
        Anthropic::IVariant<BetaRateLimitError, Beta::BetaRateLimitError>
{
    public static BetaRateLimitError From(Beta::BetaRateLimitError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaGatewayTimeoutError, Beta::BetaGatewayTimeoutError>)
)]
public sealed record class BetaGatewayTimeoutError(Beta::BetaGatewayTimeoutError Value)
    : Beta::BetaError,
        Anthropic::IVariant<BetaGatewayTimeoutError, Beta::BetaGatewayTimeoutError>
{
    public static BetaGatewayTimeoutError From(Beta::BetaGatewayTimeoutError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaAPIError, Beta::BetaAPIError>)
)]
public sealed record class BetaAPIError(Beta::BetaAPIError Value)
    : Beta::BetaError,
        Anthropic::IVariant<BetaAPIError, Beta::BetaAPIError>
{
    public static BetaAPIError From(Beta::BetaAPIError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BetaOverloadedError, Beta::BetaOverloadedError>)
)]
public sealed record class BetaOverloadedError(Beta::BetaOverloadedError Value)
    : Beta::BetaError,
        Anthropic::IVariant<BetaOverloadedError, Beta::BetaOverloadedError>
{
    public static BetaOverloadedError From(Beta::BetaOverloadedError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
