// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class PercentileMetricListResult
    {
        internal static PercentileMetricListResult DeserializePercentileMetricListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PercentileMetric>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<PercentileMetric> array = new List<PercentileMetric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PercentileMetric.DeserializePercentileMetric(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PercentileMetricListResult(Optional.ToList(value));
        }
    }
}
