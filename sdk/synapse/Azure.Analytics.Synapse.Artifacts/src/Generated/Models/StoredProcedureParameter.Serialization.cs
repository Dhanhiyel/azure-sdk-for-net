// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class StoredProcedureParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteObjectValue(Value);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static StoredProcedureParameter DeserializeStoredProcedureParameter(JsonElement element)
        {
            Optional<object> value = default;
            Optional<StoredProcedureParameterType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new StoredProcedureParameterType(property.Value.GetString());
                    continue;
                }
            }
            return new StoredProcedureParameter(value.Value, Optional.ToNullable(type));
        }
    }
}
