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
        public long? Radius { get; set; }

        [JsonProperty("states", NullValueHandling = NullValueHandling.Ignore)]
        public States States { get; set; }

        public Marker()
        {

        }

        public Marker(bool? enabled = null, string symbol = null, long? radius = null, States states = null)
        {
            Enabled = enabled;
            Symbol = symbol;
            Radius = radius;
            States = states;
        }
    }
}