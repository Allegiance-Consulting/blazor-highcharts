using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Tooltip
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }
        [JsonProperty("pointFormat", NullValueHandling = NullValueHandling.Ignore)]
        public string PointFormat { get; set; }

        public Tooltip()
        {

        }

        public Tooltip(bool? enabled = null, string pointFormat = null)
        {
            Enabled = enabled;
            PointFormat = pointFormat;
        }
    }
}
