// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers.Models
{
    public partial class PhoneNumberOperation
    {
        internal static PhoneNumberOperation DeserializePhoneNumberOperation(JsonElement element)
        {
            PhoneNumberOperationStatus status = default;
            Optional<string> resourceLocation = default;
            DateTimeOffset createdDateTime = default;
            Optional<CommunicationError> error = default;
            string id = default;
            PhoneNumberOperationType operationType = default;
            Optional<DateTimeOffset> lastActionDateTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = new PhoneNumberOperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceLocation"))
                {
                    resourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = CommunicationError.DeserializeCommunicationError(property.Value);
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationType"))
                {
                    operationType = new PhoneNumberOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastActionDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastActionDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new PhoneNumberOperation(status, resourceLocation.Value, createdDateTime, error.Value, id, operationType, Optional.ToNullable(lastActionDateTime));
        }
    }
}
