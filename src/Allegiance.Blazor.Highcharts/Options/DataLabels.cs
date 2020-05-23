using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class DataLabels
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        public DataLabels()
        {

        }

        public DataLabels(bool? enabled = null)
        {
            Enabled = enabled;
        }
    }
}
