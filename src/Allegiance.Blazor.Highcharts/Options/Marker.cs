using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Marker
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }

        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
        public int? Radius { get; set; }

        [JsonProperty("states", NullValueHandling = NullValueHandling.Ignore)]
        public States States { get; set; }

        [JsonProperty("lineWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? LineWidth { get; set; }
        [JsonProperty("lineColor", NullValueHandling = NullValueHandling.Ignore)]
        public string LineColor { get; set; }
        [JsonProperty("fillColor", NullValueHandling = NullValueHandling.Ignore)]
        public string FillColor { get; set; }

        public Marker()
        {
            
        }

        public Marker(bool? enabled = null, string symbol = null, int? radius = null, States states = null)
        {
            Enabled = enabled;
            Symbol = symbol;
            Radius = radius;
            States = states;
        }
    }
}