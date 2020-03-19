using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Hover
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        public Hover()
        {

        }

        public Hover(bool? enabled)
        {
            Enabled = enabled;
        }
    }
}