using Anthropic = Anthropic;
using Models = Anthropic.Models;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.ErrorObjectVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<InvalidRequestError, Models::InvalidRequestError>)
)]
public sealed record class InvalidRequestError(Models::InvalidRequestError Value)
    : Models::ErrorObject,
        Anthropic::IVariant<InvalidRequestError, Models::InvalidRequestError>
{
    public static InvalidRequestError From(Models::InvalidRequestError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<AuthenticationError, Models::AuthenticationError>)
)]
public sealed record class AuthenticationError(Models::AuthenticationError Value)
    : Models::ErrorObject,
        Anthropic::IVariant<AuthenticationError, Models::AuthenticationError>
{
    public static AuthenticationError From(Models::AuthenticationError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<BillingError, Models::BillingError>)
)]
public sealed record class BillingError(Models::BillingError Value)
    : Models::ErrorObject,
        Anthropic::IVariant<BillingError, Models::BillingError>
{
    public static BillingError From(Models::BillingError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<PermissionError, Models::PermissionError>)
)]
public sealed record class PermissionError(Models::PermissionError Value)
    : Models::ErrorObject,
        Anthropic::IVariant<PermissionError, Models::PermissionError>
{
    public static PermissionError From(Models::PermissionError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<NotFoundError, Models::NotFoundError>)
)]
public sealed record class NotFoundError(Models::NotFoundError Value)
    : Models::ErrorObject,
        Anthropic::IVariant<NotFoundError, Models::NotFoundError>
{
    public static NotFoundError From(Models::NotFoundError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<RateLimitError, Models::RateLimitError>)
)]
public sealed record class RateLimitError(Models::RateLimitError Value)
    : Models::ErrorObject,
        Anthropic::IVariant<RateLimitError, Models::RateLimitError>
{
    public static RateLimitError From(Models::RateLimitError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<GatewayTimeoutError, Models::GatewayTimeoutError>)
)]
public sealed record class GatewayTimeoutError(Models::GatewayTimeoutError Value)
    : Models::ErrorObject,
        Anthropic::IVariant<GatewayTimeoutError, Models::GatewayTimeoutError>
{
    public static GatewayTimeoutError From(Models::GatewayTimeoutError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<APIErrorObject, Models::APIErrorObject>)
)]
public sealed record class APIErrorObject(Models::APIErrorObject Value)
    : Models::ErrorObject,
        Anthropic::IVariant<APIErrorObject, Models::APIErrorObject>
{
    public static APIErrorObject From(Models::APIErrorObject value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<OverloadedError, Models::OverloadedError>)
)]
public sealed record class OverloadedError(Models::OverloadedError Value)
    : Models::ErrorObject,
        Anthropic::IVariant<OverloadedError, Models::OverloadedError>
{
    public static OverloadedError From(Models::OverloadedError value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
