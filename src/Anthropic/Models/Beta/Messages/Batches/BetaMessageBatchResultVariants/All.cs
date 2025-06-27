using Anthropic = Anthropic;
using Batches = Anthropic.Models.Beta.Messages.Batches;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.Batches.BetaMessageBatchResultVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaMessageBatchSucceededResult,
        Batches::BetaMessageBatchSucceededResult
    >)
)]
public sealed record class BetaMessageBatchSucceededResult(
    Batches::BetaMessageBatchSucceededResult Value
)
    : Batches::BetaMessageBatchResult,
        Anthropic::IVariant<
            BetaMessageBatchSucceededResult,
            Batches::BetaMessageBatchSucceededResult
        >
{
    public static BetaMessageBatchSucceededResult From(
        Batches::BetaMessageBatchSucceededResult value
    )
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaMessageBatchErroredResult,
        Batches::BetaMessageBatchErroredResult
    >)
)]
public sealed record class BetaMessageBatchErroredResult(
    Batches::BetaMessageBatchErroredResult Value
)
    : Batches::BetaMessageBatchResult,
        Anthropic::IVariant<BetaMessageBatchErroredResult, Batches::BetaMessageBatchErroredResult>
{
    public static BetaMessageBatchErroredResult From(Batches::BetaMessageBatchErroredResult value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaMessageBatchCanceledResult,
        Batches::BetaMessageBatchCanceledResult
    >)
)]
public sealed record class BetaMessageBatchCanceledResult(
    Batches::BetaMessageBatchCanceledResult Value
)
    : Batches::BetaMessageBatchResult,
        Anthropic::IVariant<BetaMessageBatchCanceledResult, Batches::BetaMessageBatchCanceledResult>
{
    public static BetaMessageBatchCanceledResult From(Batches::BetaMessageBatchCanceledResult value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        BetaMessageBatchExpiredResult,
        Batches::BetaMessageBatchExpiredResult
    >)
)]
public sealed record class BetaMessageBatchExpiredResult(
    Batches::BetaMessageBatchExpiredResult Value
)
    : Batches::BetaMessageBatchResult,
        Anthropic::IVariant<BetaMessageBatchExpiredResult, Batches::BetaMessageBatchExpiredResult>
{
    public static BetaMessageBatchExpiredResult From(Batches::BetaMessageBatchExpiredResult value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
