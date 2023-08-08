using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class Tooltip
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }
        [JsonProperty("shared", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shared { get; set; }
        [JsonProperty("useHTML", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseHTML { get; set; }
        [JsonProperty("pointFormat", NullValueHandling = NullValueHandling.Ignore)]
        public string PointFormat { get; set; }
        [JsonProperty("formatter", NullValueHandling = NullValueHandling.Ignore)]
        public string Formatter { get; set; }
        [JsonProperty("headerFormat", NullValueHandling = NullValueHandling.Ignore)]
        public string HeaderFormat { get; set; }
        [JsonProperty("valuePrefix", NullValueHandling = NullValueHandling.Ignore)]
        public string ValuePrefix { get; set; }
        [JsonProperty("split", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Split { get; set; }
        [JsonProperty("distance", NullValueHandling = NullValueHandling.Ignore)]
        public int? Distance { get; set; }
        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore)]
        public int? Padding { get; set; }
        [JsonProperty("valueSuffix", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueSuffix { get; set; }
        [JsonProperty("outside", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Outside { get; set; }

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
