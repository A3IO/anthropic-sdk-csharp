using Anthropic = Anthropic;
using BetaMessageBatchResultVariants = Anthropic.Models.Beta.Messages.Batches.BetaMessageBatchResultVariants;
using Serialization = System.Text.Json.Serialization;

namespace Anthropic.Models.Beta.Messages.Batches;

/// <summary>
/// Processing result for this request.
///
/// Contains a Message output if processing was successful, an error response if processing
/// failed, or the reason why processing was not attempted, such as cancellation
/// or expiration.
/// </summary>
[Serialization::JsonConverter(typeof(Anthropic::UnionConverter<BetaMessageBatchResult>))]
public abstract record class BetaMessageBatchResult
{
    internal BetaMessageBatchResult() { }

    public static BetaMessageBatchResultVariants::BetaMessageBatchSucceededResult Create(
        BetaMessageBatchSucceededResult value
    ) => new(value);

    public static BetaMessageBatchResultVariants::BetaMessageBatchErroredResult Create(
        BetaMessageBatchErroredResult value
    ) => new(value);

    public static BetaMessageBatchResultVariants::BetaMessageBatchCanceledResult Create(
        BetaMessageBatchCanceledResult value
    ) => new(value);

    public static BetaMessageBatchResultVariants::BetaMessageBatchExpiredResult Create(
        BetaMessageBatchExpiredResult value
    ) => new(value);

    public abstract void Validate();
}
