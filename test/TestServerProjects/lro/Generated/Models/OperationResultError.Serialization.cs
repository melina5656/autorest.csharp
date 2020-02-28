// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace lro.Models
{
    public partial class OperationResultError : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Code != null)
            {
                writer.WritePropertyName("code");
                writer.WriteNumberValue(Code.Value);
            }
            if (Message != null)
            {
                writer.WritePropertyName("message");
                writer.WriteStringValue(Message);
            }
            writer.WriteEndObject();
        }
        internal static OperationResultError DeserializeOperationResultError(JsonElement element)
        {
            OperationResultError result = new OperationResultError();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Code = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Message = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
