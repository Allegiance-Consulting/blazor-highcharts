using Newtonsoft.Json;
using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Background
    {
        [JsonProperty("backgroundColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundColor { get; set; }
        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
        public string Shape { get; set; }

        [JsonProperty("outerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public string OuterRadius { get; set; }

        [JsonProperty("innerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public string InnerRadius { get; set; }

        [JsonProperty("borderWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? BorderWidth { get; set; }

        //////////////////////////////////////////////////////




    }
}
