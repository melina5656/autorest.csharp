// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace AnomalyDetector.Models
{
    public partial class UnivariateEntireDetectionResult : IUtf8JsonSerializable, IJsonModel<UnivariateEntireDetectionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UnivariateEntireDetectionResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UnivariateEntireDetectionResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateEntireDetectionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UnivariateEntireDetectionResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("period"u8);
            writer.WriteNumberValue(Period);
            writer.WritePropertyName("expectedValues"u8);
            writer.WriteStartArray();
            foreach (var item in ExpectedValues)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("upperMargins"u8);
            writer.WriteStartArray();
            foreach (var item in UpperMargins)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("lowerMargins"u8);
            writer.WriteStartArray();
            foreach (var item in LowerMargins)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("isAnomaly"u8);
            writer.WriteStartArray();
            foreach (var item in IsAnomaly)
            {
                writer.WriteBooleanValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("isNegativeAnomaly"u8);
            writer.WriteStartArray();
            foreach (var item in IsNegativeAnomaly)
            {
                writer.WriteBooleanValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("isPositiveAnomaly"u8);
            writer.WriteStartArray();
            foreach (var item in IsPositiveAnomaly)
            {
                writer.WriteBooleanValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStartArray();
                foreach (var item in Severity)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
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

        UnivariateEntireDetectionResult IJsonModel<UnivariateEntireDetectionResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateEntireDetectionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UnivariateEntireDetectionResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnivariateEntireDetectionResult(document.RootElement, options);
        }

        internal static UnivariateEntireDetectionResult DeserializeUnivariateEntireDetectionResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int period = default;
            IReadOnlyList<float> expectedValues = default;
            IReadOnlyList<float> upperMargins = default;
            IReadOnlyList<float> lowerMargins = default;
            IReadOnlyList<bool> isAnomaly = default;
            IReadOnlyList<bool> isNegativeAnomaly = default;
            IReadOnlyList<bool> isPositiveAnomaly = default;
            IReadOnlyList<float> severity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("period"u8))
                {
                    period = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("expectedValues"u8))
                {
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    expectedValues = array;
                    continue;
                }
                if (property.NameEquals("upperMargins"u8))
                {
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    upperMargins = array;
                    continue;
                }
                if (property.NameEquals("lowerMargins"u8))
                {
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    lowerMargins = array;
                    continue;
                }
                if (property.NameEquals("isAnomaly"u8))
                {
                    List<bool> array = new List<bool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetBoolean());
                    }
                    isAnomaly = array;
                    continue;
                }
                if (property.NameEquals("isNegativeAnomaly"u8))
                {
                    List<bool> array = new List<bool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetBoolean());
                    }
                    isNegativeAnomaly = array;
                    continue;
                }
                if (property.NameEquals("isPositiveAnomaly"u8))
                {
                    List<bool> array = new List<bool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetBoolean());
                    }
                    isPositiveAnomaly = array;
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    severity = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnivariateEntireDetectionResult(
                period,
                expectedValues,
                upperMargins,
                lowerMargins,
                isAnomaly,
                isNegativeAnomaly,
                isPositiveAnomaly,
                severity ?? new ChangeTrackingList<float>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UnivariateEntireDetectionResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateEntireDetectionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UnivariateEntireDetectionResult)} does not support writing '{options.Format}' format.");
            }
        }

        UnivariateEntireDetectionResult IPersistableModel<UnivariateEntireDetectionResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateEntireDetectionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnivariateEntireDetectionResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UnivariateEntireDetectionResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UnivariateEntireDetectionResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static UnivariateEntireDetectionResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnivariateEntireDetectionResult(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<UnivariateEntireDetectionResult>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
