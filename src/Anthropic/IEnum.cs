namespace Anthropic;

public interface IEnum<IE, T>
    where IE : IEnum<IE, T>
{
    static abstract IE FromRaw(T value);
    T Raw();
}
