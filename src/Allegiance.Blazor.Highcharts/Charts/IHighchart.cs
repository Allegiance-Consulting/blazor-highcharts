using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Allegiance.Blazor.Highcharts.Core.Charts
{
    public interface IHighchart
    {
        string Generate()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull });
        }
    }
}
