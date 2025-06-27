using Anthropic = Anthropic;
using ErrorObjectVariants = Anthropic.Models.ErrorObjectVariants;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models;

[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<ErrorObject>))]
public abstract record class ErrorObject
{
    internal ErrorObject() { }

    public static ErrorObjectVariants::InvalidRequestError Create(InvalidRequestError value) =>
        new(value);

    public static ErrorObjectVariants::AuthenticationError Create(AuthenticationError value) =>
        new(value);

    public static ErrorObjectVariants::BillingError Create(BillingError value) => new(value);

    public static ErrorObjectVariants::PermissionError Create(PermissionError value) => new(value);

    public static ErrorObjectVariants::NotFoundError Create(NotFoundError value) => new(value);

    public static ErrorObjectVariants::RateLimitError Create(RateLimitError value) => new(value);

    public static ErrorObjectVariants::GatewayTimeoutError Create(GatewayTimeoutError value) =>
        new(value);

    public static ErrorObjectVariants::APIErrorObject Create(APIErrorObject value) => new(value);

    public static ErrorObjectVariants::OverloadedError Create(OverloadedError value) => new(value);

    public abstract void Validate();
}
