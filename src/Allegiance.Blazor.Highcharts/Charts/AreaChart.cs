using Allegiance.Blazor.Highcharts.Constants;
using Allegiance.Blazor.Highcharts.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Allegiance.Blazor.Highcharts.Charts
{
    public partial class AreaChart : IHighchart
    {
        [JsonProperty("chart", NullValueHandling = NullValueHandling.Ignore)]
        public Chart Chart { get; } = new Chart(ChartType.Area);

        [JsonProperty("accessibility", NullValueHandling = NullValueHandling.Ignore)]
        public Accessibility Accessibility { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public Title Title { get; set; }

        [JsonProperty("subtitle", NullValueHandling = NullValueHandling.Ignore)]
        public Title Subtitle { get; set; }

        [JsonProperty("xAxis", NullValueHandling = NullValueHandling.Ignore)]
        public XAxis XAxis { get; set; }

        [JsonProperty("yAxis", NullValueHandling = NullValueHandling.Ignore)]
        public YAxis YAxis { get; set; }

        [JsonProperty("tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public Tooltip Tooltip { get; set; }

        [JsonProperty("plotOptions", NullValueHandling = NullValueHandling.Ignore)]
        public PlotOptions PlotOptions { get; set; }

        [JsonProperty("series", NullValueHandling = NullValueHandling.Ignore)]
        public List<SeriesElement> Series { get; set; }

        public string Generate()
        {
            return System.Text.Json.JsonSerializer.Serialize(this, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, IgnoreNullValues = true });
        }
    }
}
