// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class BlobServiceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Sku != null)
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Cors != null)
            {
                writer.WritePropertyName("cors");
                writer.WriteObjectValue(Cors);
            }
            if (DefaultServiceVersion != null)
            {
                writer.WritePropertyName("defaultServiceVersion");
                writer.WriteStringValue(DefaultServiceVersion);
            }
            if (DeleteRetentionPolicy != null)
            {
                writer.WritePropertyName("deleteRetentionPolicy");
                writer.WriteObjectValue(DeleteRetentionPolicy);
            }
            if (IsVersioningEnabled != null)
            {
                writer.WritePropertyName("isVersioningEnabled");
                writer.WriteBooleanValue(IsVersioningEnabled.Value);
            }
            if (AutomaticSnapshotPolicyEnabled != null)
            {
                writer.WritePropertyName("automaticSnapshotPolicyEnabled");
                writer.WriteBooleanValue(AutomaticSnapshotPolicyEnabled.Value);
            }
            if (ChangeFeed != null)
            {
                writer.WritePropertyName("changeFeed");
                writer.WriteObjectValue(ChangeFeed);
            }
            if (RestorePolicy != null)
            {
                writer.WritePropertyName("restorePolicy");
                writer.WriteObjectValue(RestorePolicy);
            }
            if (ContainerDeleteRetentionPolicy != null)
            {
                writer.WritePropertyName("containerDeleteRetentionPolicy");
                writer.WriteObjectValue(ContainerDeleteRetentionPolicy);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BlobServiceProperties DeserializeBlobServiceProperties(JsonElement element)
        {
            BlobServiceProperties result = new BlobServiceProperties();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Sku = Sku.DeserializeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("cors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.Cors = CorsRules.DeserializeCorsRules(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultServiceVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.DefaultServiceVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deleteRetentionPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.DeleteRetentionPolicy = DeleteRetentionPolicy.DeserializeDeleteRetentionPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isVersioningEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.IsVersioningEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("automaticSnapshotPolicyEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.AutomaticSnapshotPolicyEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("changeFeed"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.ChangeFeed = ChangeFeed.DeserializeChangeFeed(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("restorePolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.RestorePolicy = RestorePolicyProperties.DeserializeRestorePolicyProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("containerDeleteRetentionPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.ContainerDeleteRetentionPolicy = DeleteRetentionPolicy.DeserializeDeleteRetentionPolicy(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
