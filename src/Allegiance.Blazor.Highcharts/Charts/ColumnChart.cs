using System.Collections.Generic;
using Allegiance.Blazor.Highcharts.Options;
using Newtonsoft.Json;
using System;
using System.Text.Json;

namespace Allegiance.Blazor.Highcharts.Charts
{
    public partial class ColumnChart : IHighchart
    {

        [JsonProperty("chart", Required = Required.Always)]
        public Chart Chart { get; set; }

        [JsonProperty("title", Required = Required.Always)]
        public Title Title { get; set; }

        [JsonProperty("xAxis", Required = Required.Always)]
        public XAxis XAxis { get; set; }

        [JsonProperty("yAxis", Required = Required.Always)]
        public YAxis YAxis { get; set; }

        [JsonProperty("legend", Required = Required.Always)]
        public Legend Legend { get; set; }

        [JsonProperty("plotOptions", Required = Required.Always)]
        public PlotOptions PlotOptions { get; set; }

        [JsonProperty("series", Required = Required.Always)]
        public List<SeriesElement> Series { get; set; }




        public string Generate()
        {
            return System.Text.Json.JsonSerializer.Serialize(this, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, IgnoreNullValues = true });
        }
    }
}
