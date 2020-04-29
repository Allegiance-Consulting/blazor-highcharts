using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Hover
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }
        [JsonProperty("halo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halo { get; set; }
        [JsonProperty("lineColor", NullValueHandling = NullValueHandling.Ignore)]
        public string LineColor { get; set; }
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public Marker Marker  { get; set; }

        public Hover()
        {

        }

        public Hover(bool? enabled = null)
        {
            Enabled = enabled;
        }
    }
}