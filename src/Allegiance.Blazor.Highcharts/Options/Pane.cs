using Newtonsoft.Json;
using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Pane
    {
        [JsonProperty("startAngle", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartAngle { get; set; }
        [JsonProperty("endAngle", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndAngle { get; set; }

        [JsonProperty("background", NullValueHandling = NullValueHandling.Ignore)]
        public List<Background> Background { get; set; }
        [JsonProperty("center", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Center { get; set; }
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        /////




    }
}
