using Anthropic = Anthropic;
using Batches = Anthropic.Models.Messages.Batches;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.Batches.MessageBatchResultVariants;

[Serialization::JsonConverter(
    typeof(Anthropic::VariantConverter<
        MessageBatchSucceededResult,
        Batches::MessageBatchSucceededResult
    >)
)]
public sealed record class MessageBatchSucceededResult(Batches::MessageBatchSucceededResult Value)
    : Batches::MessageBatchResult,
        Anthropic::IVariant<MessageBatchSucceededResult, Batches::MessageBatchSucceededResult>
{
    public static MessageBatchSucceededResult From(Batches::MessageBatchSucceededResult value)
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
        MessageBatchErroredResult,
        Batches::MessageBatchErroredResult
    >)
)]
public sealed record class MessageBatchErroredResult(Batches::MessageBatchErroredResult Value)
    : Batches::MessageBatchResult,
        Anthropic::IVariant<MessageBatchErroredResult, Batches::MessageBatchErroredResult>
{
    public static MessageBatchErroredResult From(Batches::MessageBatchErroredResult value)
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
        MessageBatchCanceledResult,
        Batches::MessageBatchCanceledResult
    >)
)]
public sealed record class MessageBatchCanceledResult(Batches::MessageBatchCanceledResult Value)
    : Batches::MessageBatchResult,
        Anthropic::IVariant<MessageBatchCanceledResult, Batches::MessageBatchCanceledResult>
{
    public static MessageBatchCanceledResult From(Batches::MessageBatchCanceledResult value)
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
        MessageBatchExpiredResult,
        Batches::MessageBatchExpiredResult
    >)
)]
public sealed record class MessageBatchExpiredResult(Batches::MessageBatchExpiredResult Value)
    : Batches::MessageBatchResult,
        Anthropic::IVariant<MessageBatchExpiredResult, Batches::MessageBatchExpiredResult>
{
    public static MessageBatchExpiredResult From(Batches::MessageBatchExpiredResult value)
    {
        return new(value);
    }

    public override void Validate()
    {
        this.Value.Validate();
    }
}
