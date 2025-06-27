using Generic = System.Collections.Generic;
using Json = System.Text.Json;

namespace Anthropic;

public abstract record class ModelBase
{
    public Generic::Dictionary<string, Json::JsonElement> Properties { get; set; } = [];

    static readonly Json::JsonSerializerOptions _toStringSerializerOptions = new()
    {
        WriteIndented = true,
    };

    public sealed override string? ToString()
    {
        return Json::JsonSerializer.Serialize(this.Properties, _toStringSerializerOptions);
    }

    public abstract void Validate();
}

public interface IFromRaw<T>
{
    static abstract T FromRawUnchecked(Generic::Dictionary<string, Json::JsonElement> properties);
}
