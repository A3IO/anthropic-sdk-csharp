namespace Anthropic;

public interface IVariant<IV, T>
    where IV : IVariant<IV, T>
{
    static abstract IV From(T value);
    T Value { get; }
}
