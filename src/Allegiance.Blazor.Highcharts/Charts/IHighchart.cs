using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Allegiance.Blazor.Highcharts.Charts
{
    public interface IHighchart
    {
        string Generate()//change
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, IgnoreNullValues = true });
        }
    }
}
