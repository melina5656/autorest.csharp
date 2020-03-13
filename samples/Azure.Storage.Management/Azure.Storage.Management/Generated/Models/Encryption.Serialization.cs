// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class Encryption : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Services != null)
            {
                writer.WritePropertyName("services");
                writer.WriteObjectValue(Services);
            }
            writer.WritePropertyName("keySource");
            writer.WriteStringValue(KeySource.ToString());
            if (KeyVaultProperties != null)
            {
                writer.WritePropertyName("keyvaultproperties");
                writer.WriteObjectValue(KeyVaultProperties);
            }
            writer.WriteEndObject();
        }

        internal static Encryption DeserializeEncryption(JsonElement element)
        {
            Encryption result = new Encryption();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("services"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Services = EncryptionServices.DeserializeEncryptionServices(property.Value);
                    continue;
                }
                if (property.NameEquals("keySource"))
                {
                    result.KeySource = new KeySource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyvaultproperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.KeyVaultProperties = KeyVaultProperties.DeserializeKeyVaultProperties(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}
