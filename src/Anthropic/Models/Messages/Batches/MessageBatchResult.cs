using Anthropic = Anthropic;
using MessageBatchResultVariants = Anthropic.Models.Messages.Batches.MessageBatchResultVariants;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Messages.Batches;

/// <summary>
/// Processing result for this request.
///
/// Contains a Message output if processing was successful, an error response if processing
/// failed, or the reason why processing was not attempted, such as cancellation
/// or expiration.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<MessageBatchResult>))]
public abstract record class MessageBatchResult
{
    internal MessageBatchResult() { }

    public static MessageBatchResultVariants::MessageBatchSucceededResult Create(
        MessageBatchSucceededResult value
    ) => new(value);

    public static MessageBatchResultVariants::MessageBatchErroredResult Create(
        MessageBatchErroredResult value
    ) => new(value);

    public static MessageBatchResultVariants::MessageBatchCanceledResult Create(
        MessageBatchCanceledResult value
    ) => new(value);

    public static MessageBatchResultVariants::MessageBatchExpiredResult Create(
        MessageBatchExpiredResult value
    ) => new(value);

    public abstract void Validate();
}
