// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace UnbrandedTypeSpec.Models
{
    public partial class RoundTripModel : IJsonModel<RoundTripModel>
    {
        void IJsonModel<RoundTripModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoundTripModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoundTripModel)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("requiredString"u8);
            writer.WriteStringValue(RequiredString);
            writer.WritePropertyName("requiredInt"u8);
            writer.WriteNumberValue(RequiredInt);
            writer.WritePropertyName("requiredCollection"u8);
            writer.WriteStartArray();
            foreach (var item in RequiredCollection)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item.Value.ToSerialString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("requiredDictionary"u8);
            writer.WriteStartObject();
            foreach (var item in RequiredDictionary)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item.Value.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WritePropertyName("requiredModel"u8);
            writer.WriteObjectValue<Thing>(RequiredModel, options);
            if (Optional.IsDefined(IntExtensibleEnum))
            {
                writer.WritePropertyName("intExtensibleEnum"u8);
                writer.WriteNumberValue(IntExtensibleEnum.Value.ToSerialInt32());
            }
            if (Optional.IsCollectionDefined(IntExtensibleEnumCollection))
            {
                writer.WritePropertyName("intExtensibleEnumCollection"u8);
                writer.WriteStartArray();
                foreach (var item in IntExtensibleEnumCollection)
                {
                    writer.WriteNumberValue(item.ToSerialInt32());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FloatExtensibleEnum))
            {
                writer.WritePropertyName("floatExtensibleEnum"u8);
                writer.WriteNumberValue(FloatExtensibleEnum.Value.ToSerialInt32());
            }
            if (Optional.IsCollectionDefined(FloatExtensibleEnumCollection))
            {
                writer.WritePropertyName("floatExtensibleEnumCollection"u8);
                writer.WriteStartArray();
                foreach (var item in FloatExtensibleEnumCollection)
                {
                    writer.WriteNumberValue(item.ToSerialInt32());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FloatFixedEnum))
            {
                writer.WritePropertyName("floatFixedEnum"u8);
                writer.WriteNumberValue(FloatFixedEnum.Value.ToSerialSingle());
            }
            if (Optional.IsCollectionDefined(FloatFixedEnumCollection))
            {
                writer.WritePropertyName("floatFixedEnumCollection"u8);
                writer.WriteStartArray();
                foreach (var item in FloatFixedEnumCollection)
                {
                    writer.WriteNumberValue(item.ToSerialSingle());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IntFixedEnum))
            {
                writer.WritePropertyName("intFixedEnum"u8);
                writer.WriteNumberValue((int)IntFixedEnum.Value);
            }
            if (Optional.IsCollectionDefined(IntFixedEnumCollection))
            {
                writer.WritePropertyName("intFixedEnumCollection"u8);
                writer.WriteStartArray();
                foreach (var item in IntFixedEnumCollection)
                {
                    writer.WriteNumberValue((int)item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StringFixedEnum))
            {
                if (StringFixedEnum != null)
                {
                    writer.WritePropertyName("stringFixedEnum"u8);
                    writer.WriteStringValue(StringFixedEnum.Value.ToSerialString());
                }
                else
                {
                    writer.WriteNull("stringFixedEnum");
                }
            }
            writer.WritePropertyName("requiredUnknown"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(RequiredUnknown);
#else
            using (JsonDocument document = JsonDocument.Parse(RequiredUnknown))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            if (Optional.IsDefined(OptionalUnknown))
            {
                writer.WritePropertyName("optionalUnknown"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(OptionalUnknown);
#else
                using (JsonDocument document = JsonDocument.Parse(OptionalUnknown))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WritePropertyName("requiredRecordUnknown"u8);
            writer.WriteStartObject();
            foreach (var item in RequiredRecordUnknown)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
            if (Optional.IsCollectionDefined(OptionalRecordUnknown))
            {
                writer.WritePropertyName("optionalRecordUnknown"u8);
                writer.WriteStartObject();
                foreach (var item in OptionalRecordUnknown)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("readOnlyRequiredRecordUnknown"u8);
                writer.WriteStartObject();
                foreach (var item in ReadOnlyRequiredRecordUnknown)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ReadOnlyOptionalRecordUnknown))
            {
                writer.WritePropertyName("readOnlyOptionalRecordUnknown"u8);
                writer.WriteStartObject();
                foreach (var item in ReadOnlyOptionalRecordUnknown)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("modelWithRequiredNullable"u8);
            writer.WriteObjectValue<ModelWithRequiredNullableProperties>(ModelWithRequiredNullable, options);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RoundTripModel IJsonModel<RoundTripModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoundTripModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoundTripModel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoundTripModel(document.RootElement, options);
        }

        internal static RoundTripModel DeserializeRoundTripModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string requiredString = default;
            int requiredInt = default;
            IList<StringFixedEnum?> requiredCollection = default;
            IDictionary<string, StringExtensibleEnum?> requiredDictionary = default;
            Thing requiredModel = default;
            IntExtensibleEnum? intExtensibleEnum = default;
            IList<IntExtensibleEnum> intExtensibleEnumCollection = default;
            FloatExtensibleEnum? floatExtensibleEnum = default;
            IList<FloatExtensibleEnum> floatExtensibleEnumCollection = default;
            FloatFixedEnum? floatFixedEnum = default;
            IList<FloatFixedEnum> floatFixedEnumCollection = default;
            IntFixedEnum? intFixedEnum = default;
            IList<IntFixedEnum> intFixedEnumCollection = default;
            StringFixedEnum? stringFixedEnum = default;
            BinaryData requiredUnknown = default;
            BinaryData optionalUnknown = default;
            IDictionary<string, BinaryData> requiredRecordUnknown = default;
            IDictionary<string, BinaryData> optionalRecordUnknown = default;
            IReadOnlyDictionary<string, BinaryData> readOnlyRequiredRecordUnknown = default;
            IReadOnlyDictionary<string, BinaryData> readOnlyOptionalRecordUnknown = default;
            ModelWithRequiredNullableProperties modelWithRequiredNullable = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requiredString"u8))
                {
                    requiredString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requiredInt"u8))
                {
                    requiredInt = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("requiredCollection"u8))
                {
                    List<StringFixedEnum?> array = new List<StringFixedEnum?>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString().ToStringFixedEnum());
                        }
                    }
                    requiredCollection = array;
                    continue;
                }
                if (property.NameEquals("requiredDictionary"u8))
                {
                    Dictionary<string, StringExtensibleEnum?> dictionary = new Dictionary<string, StringExtensibleEnum?>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, new StringExtensibleEnum(property0.Value.GetString()));
                        }
                    }
                    requiredDictionary = dictionary;
                    continue;
                }
                if (property.NameEquals("requiredModel"u8))
                {
                    requiredModel = Thing.DeserializeThing(property.Value, options);
                    continue;
                }
                if (property.NameEquals("intExtensibleEnum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    intExtensibleEnum = new IntExtensibleEnum(property.Value.GetInt32());
                    continue;
                }
                if (property.NameEquals("intExtensibleEnumCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IntExtensibleEnum> array = new List<IntExtensibleEnum>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IntExtensibleEnum(item.GetInt32()));
                    }
                    intExtensibleEnumCollection = array;
                    continue;
                }
                if (property.NameEquals("floatExtensibleEnum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    floatExtensibleEnum = new FloatExtensibleEnum(property.Value.GetInt32());
                    continue;
                }
                if (property.NameEquals("floatExtensibleEnumCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FloatExtensibleEnum> array = new List<FloatExtensibleEnum>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new FloatExtensibleEnum(item.GetInt32()));
                    }
                    floatExtensibleEnumCollection = array;
                    continue;
                }
                if (property.NameEquals("floatFixedEnum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    floatFixedEnum = property.Value.GetSingle().ToFloatFixedEnum();
                    continue;
                }
                if (property.NameEquals("floatFixedEnumCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FloatFixedEnum> array = new List<FloatFixedEnum>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle().ToFloatFixedEnum());
                    }
                    floatFixedEnumCollection = array;
                    continue;
                }
                if (property.NameEquals("intFixedEnum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    intFixedEnum = property.Value.GetInt32().ToIntFixedEnum();
                    continue;
                }
                if (property.NameEquals("intFixedEnumCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IntFixedEnum> array = new List<IntFixedEnum>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32().ToIntFixedEnum());
                    }
                    intFixedEnumCollection = array;
                    continue;
                }
                if (property.NameEquals("stringFixedEnum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stringFixedEnum = null;
                        continue;
                    }
                    stringFixedEnum = property.Value.GetString().ToStringFixedEnum();
                    continue;
                }
                if (property.NameEquals("requiredUnknown"u8))
                {
                    requiredUnknown = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("optionalUnknown"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optionalUnknown = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("requiredRecordUnknown"u8))
                {
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    requiredRecordUnknown = dictionary;
                    continue;
                }
                if (property.NameEquals("optionalRecordUnknown"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    optionalRecordUnknown = dictionary;
                    continue;
                }
                if (property.NameEquals("readOnlyRequiredRecordUnknown"u8))
                {
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    readOnlyRequiredRecordUnknown = dictionary;
                    continue;
                }
                if (property.NameEquals("readOnlyOptionalRecordUnknown"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    readOnlyOptionalRecordUnknown = dictionary;
                    continue;
                }
                if (property.NameEquals("modelWithRequiredNullable"u8))
                {
                    modelWithRequiredNullable = ModelWithRequiredNullableProperties.DeserializeModelWithRequiredNullableProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RoundTripModel(
                requiredString,
                requiredInt,
                requiredCollection,
                requiredDictionary,
                requiredModel,
                intExtensibleEnum,
                intExtensibleEnumCollection ?? new ChangeTrackingList<IntExtensibleEnum>(),
                floatExtensibleEnum,
                floatExtensibleEnumCollection ?? new ChangeTrackingList<FloatExtensibleEnum>(),
                floatFixedEnum,
                floatFixedEnumCollection ?? new ChangeTrackingList<FloatFixedEnum>(),
                intFixedEnum,
                intFixedEnumCollection ?? new ChangeTrackingList<IntFixedEnum>(),
                stringFixedEnum,
                requiredUnknown,
                optionalUnknown,
                requiredRecordUnknown,
                optionalRecordUnknown ?? new ChangeTrackingDictionary<string, BinaryData>(),
                readOnlyRequiredRecordUnknown,
                readOnlyOptionalRecordUnknown ?? new ChangeTrackingDictionary<string, BinaryData>(),
                modelWithRequiredNullable,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoundTripModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoundTripModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoundTripModel)} does not support writing '{options.Format}' format.");
            }
        }

        RoundTripModel IPersistableModel<RoundTripModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoundTripModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoundTripModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoundTripModel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoundTripModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static RoundTripModel FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRoundTripModel(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual BinaryContent ToBinaryBody()
        {
            return BinaryContent.Create(this, new ModelReaderWriterOptions("W"));
        }
    }
}
