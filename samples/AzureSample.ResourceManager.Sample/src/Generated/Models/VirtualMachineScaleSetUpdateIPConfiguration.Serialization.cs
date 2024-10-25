// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace AzureSample.ResourceManager.Sample.Models
{
    public partial class VirtualMachineScaleSetUpdateIPConfiguration : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetUpdateIPConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetUpdateIPConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualMachineScaleSetUpdateIPConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpdateIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpdateIPConfiguration)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet"u8);
                JsonSerializer.Serialize(writer, Subnet);
            }
            if (Optional.IsDefined(Primary))
            {
                writer.WritePropertyName("primary"u8);
                writer.WriteBooleanValue(Primary.Value);
            }
            if (Optional.IsDefined(PublicIPAddressConfiguration))
            {
                writer.WritePropertyName("publicIPAddressConfiguration"u8);
                writer.WriteObjectValue(PublicIPAddressConfiguration, options);
            }
            if (Optional.IsDefined(PrivateIPAddressVersion))
            {
                writer.WritePropertyName("privateIPAddressVersion"u8);
                writer.WriteStringValue(PrivateIPAddressVersion.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ApplicationGatewayBackendAddressPools))
            {
                writer.WritePropertyName("applicationGatewayBackendAddressPools"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationGatewayBackendAddressPools)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApplicationSecurityGroups))
            {
                writer.WritePropertyName("applicationSecurityGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationSecurityGroups)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LoadBalancerBackendAddressPools))
            {
                writer.WritePropertyName("loadBalancerBackendAddressPools"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancerBackendAddressPools)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LoadBalancerInboundNatPools))
            {
                writer.WritePropertyName("loadBalancerInboundNatPools"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancerInboundNatPools)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        VirtualMachineScaleSetUpdateIPConfiguration IJsonModel<VirtualMachineScaleSetUpdateIPConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpdateIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpdateIPConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetUpdateIPConfiguration(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetUpdateIPConfiguration DeserializeVirtualMachineScaleSetUpdateIPConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string id = default;
            WritableSubResource subnet = default;
            bool? primary = default;
            VirtualMachineScaleSetUpdatePublicIPAddressConfiguration publicIPAddressConfiguration = default;
            IPVersion? privateIPAddressVersion = default;
            IList<WritableSubResource> applicationGatewayBackendAddressPools = default;
            IList<WritableSubResource> applicationSecurityGroups = default;
            IList<WritableSubResource> loadBalancerBackendAddressPools = default;
            IList<WritableSubResource> loadBalancerInboundNatPools = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("subnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnet = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("primary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primary = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddressConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPAddressConfiguration = VirtualMachineScaleSetUpdatePublicIPAddressConfiguration.DeserializeVirtualMachineScaleSetUpdatePublicIPAddressConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("privateIPAddressVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateIPAddressVersion = new IPVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("applicationGatewayBackendAddressPools"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            applicationGatewayBackendAddressPools = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationSecurityGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            applicationSecurityGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerBackendAddressPools"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            loadBalancerBackendAddressPools = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerInboundNatPools"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            loadBalancerInboundNatPools = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualMachineScaleSetUpdateIPConfiguration(
                id,
                serializedAdditionalRawData,
                name,
                subnet,
                primary,
                publicIPAddressConfiguration,
                privateIPAddressVersion,
                applicationGatewayBackendAddressPools ?? new ChangeTrackingList<WritableSubResource>(),
                applicationSecurityGroups ?? new ChangeTrackingList<WritableSubResource>(),
                loadBalancerBackendAddressPools ?? new ChangeTrackingList<WritableSubResource>(),
                loadBalancerInboundNatPools ?? new ChangeTrackingList<WritableSubResource>());
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    if (Id.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Id}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Id}'");
                    }
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("SubnetId", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    subnet: ");
                builder.AppendLine("{");
                builder.AppendLine("      subnet: {");
                builder.Append("        id: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(Subnet))
                {
                    builder.Append("    subnet: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Subnet, options, 4, false, "    subnet: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Primary), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    primary: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Primary))
                {
                    builder.Append("    primary: ");
                    var boolValue = Primary.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PublicIPAddressConfiguration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    publicIPAddressConfiguration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PublicIPAddressConfiguration))
                {
                    builder.Append("    publicIPAddressConfiguration: ");
                    BicepSerializationHelpers.AppendChildObject(builder, PublicIPAddressConfiguration, options, 4, false, "    publicIPAddressConfiguration: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrivateIPAddressVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    privateIPAddressVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrivateIPAddressVersion))
                {
                    builder.Append("    privateIPAddressVersion: ");
                    builder.AppendLine($"'{PrivateIPAddressVersion.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApplicationGatewayBackendAddressPools), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    applicationGatewayBackendAddressPools: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ApplicationGatewayBackendAddressPools))
                {
                    if (ApplicationGatewayBackendAddressPools.Any())
                    {
                        builder.Append("    applicationGatewayBackendAddressPools: ");
                        builder.AppendLine("[");
                        foreach (var item in ApplicationGatewayBackendAddressPools)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    applicationGatewayBackendAddressPools: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApplicationSecurityGroups), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    applicationSecurityGroups: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ApplicationSecurityGroups))
                {
                    if (ApplicationSecurityGroups.Any())
                    {
                        builder.Append("    applicationSecurityGroups: ");
                        builder.AppendLine("[");
                        foreach (var item in ApplicationSecurityGroups)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    applicationSecurityGroups: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LoadBalancerBackendAddressPools), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    loadBalancerBackendAddressPools: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(LoadBalancerBackendAddressPools))
                {
                    if (LoadBalancerBackendAddressPools.Any())
                    {
                        builder.Append("    loadBalancerBackendAddressPools: ");
                        builder.AppendLine("[");
                        foreach (var item in LoadBalancerBackendAddressPools)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    loadBalancerBackendAddressPools: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LoadBalancerInboundNatPools), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    loadBalancerInboundNatPools: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(LoadBalancerInboundNatPools))
                {
                    if (LoadBalancerInboundNatPools.Any())
                    {
                        builder.Append("    loadBalancerInboundNatPools: ");
                        builder.AppendLine("[");
                        foreach (var item in LoadBalancerInboundNatPools)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    loadBalancerInboundNatPools: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetUpdateIPConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpdateIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpdateIPConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetUpdateIPConfiguration IPersistableModel<VirtualMachineScaleSetUpdateIPConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpdateIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetUpdateIPConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpdateIPConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetUpdateIPConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
