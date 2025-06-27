using Anthropic = Anthropic;
using BetaErrorVariants = Anthropic.Models.Beta.BetaErrorVariants;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<BetaError>))]
public abstract record class BetaError
{
    internal BetaError() { }

    public static BetaErrorVariants::BetaInvalidRequestError Create(
        BetaInvalidRequestError value
    ) => new(value);

    public static BetaErrorVariants::BetaAuthenticationError Create(
        BetaAuthenticationError value
    ) => new(value);

    public static BetaErrorVariants::BetaBillingError Create(BetaBillingError value) => new(value);

    public static BetaErrorVariants::BetaPermissionError Create(BetaPermissionError value) =>
        new(value);

    public static BetaErrorVariants::BetaNotFoundError Create(BetaNotFoundError value) =>
        new(value);

    public static BetaErrorVariants::BetaRateLimitError Create(BetaRateLimitError value) =>
        new(value);

    public static BetaErrorVariants::BetaGatewayTimeoutError Create(
        BetaGatewayTimeoutError value
    ) => new(value);

    public static BetaErrorVariants::BetaAPIError Create(BetaAPIError value) => new(value);

    public static BetaErrorVariants::BetaOverloadedError Create(BetaOverloadedError value) =>
        new(value);

    public abstract void Validate();
}
