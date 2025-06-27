using Generic = System.Collections.Generic;
using Json = System.Text.Json;
using Linq = System.Linq;
using Reflection = System.Reflection;
using Serialization = System.Text.Json.Serialization;
using System = System;

namespace Anthropic;

public sealed class ModelConverter<MB> : Serialization::JsonConverter<MB>
    where MB : ModelBase, IFromRaw<MB>
{
    public override MB? Read(
        ref Json::Utf8JsonReader reader,
        System::Type _typeToConvert,
        Json::JsonSerializerOptions options
    )
    {
        Generic::Dictionary<string, Json::JsonElement>? properties =
            Json::JsonSerializer.Deserialize<Generic::Dictionary<string, Json::JsonElement>>(
                ref reader,
                options
            );
        if (properties == null)
            return null;

        return MB.FromRawUnchecked(properties);
    }

    public override void Write(
        Json::Utf8JsonWriter writer,
        MB value,
        Json::JsonSerializerOptions options
    )
    {
        Json::JsonSerializer.Serialize(writer, value.Properties, options);
    }
}

public sealed class EnumConverter<IE, T> : Serialization::JsonConverter<IE>
    where IE : IEnum<IE, T>
{
    public override IE Read(
        ref Json::Utf8JsonReader reader,
        System::Type _typeToConvert,
        Json::JsonSerializerOptions options
    )
    {
        return IE.FromRaw(Json::JsonSerializer.Deserialize<T>(ref reader, options)!);
    }

    public override void Write(
        Json::Utf8JsonWriter writer,
        IE value,
        Json::JsonSerializerOptions options
    )
    {
        Json::JsonSerializer.Serialize(writer, value.Raw(), options);
    }
}

public sealed class UnionConverter<T> : Serialization::JsonConverter<T>
    where T : class
{
    readonly Generic::List<System::Type> _variantTypes = Linq::Enumerable.ToList(
        Linq::Enumerable.Where(
            Reflection::Assembly.GetExecutingAssembly().GetTypes(),
            type => type.BaseType == typeof(T)
        )
    );

    public override T? Read(
        ref Json::Utf8JsonReader reader,
        System::Type _typeToConvert,
        Json::JsonSerializerOptions options
    )
    {
        Generic::List<Json::JsonException> exceptions = [];
        foreach (var variantType in _variantTypes)
        {
            try
            {
                return Json::JsonSerializer.Deserialize(ref reader, variantType, options) as T;
            }
            catch (Json::JsonException e)
            {
                exceptions.Add(e);
            }
        }
        throw new System::AggregateException(exceptions);
    }

    public override void Write(
        Json::Utf8JsonWriter writer,
        T value,
        Json::JsonSerializerOptions options
    )
    {
        var variantType =
            _variantTypes.Find(type => type == value.GetType())
            ?? throw new System::ArgumentOutOfRangeException(value.GetType().Name);
        Json::JsonSerializer.Serialize(writer, value, variantType, options);
    }
}

public sealed class VariantConverter<IV, T> : Serialization::JsonConverter<IV>
    where IV : IVariant<IV, T>
{
    public override IV Read(
        ref Json::Utf8JsonReader reader,
        System::Type _typeToConvert,
        Json::JsonSerializerOptions options
    )
    {
        return IV.From(Json::JsonSerializer.Deserialize<T>(ref reader, options)!);
    }

    public override void Write(
        Json::Utf8JsonWriter writer,
        IV value,
        Json::JsonSerializerOptions options
    )
    {
        Json::JsonSerializer.Serialize(writer, value.Value, options);
    }
}
