using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Tooltip
    {
        [JsonProperty("pointFormat", NullValueHandling = NullValueHandling.Ignore)]
        public string PointFormat { get; set; }

        public Tooltip()
        {

        }

        public Tooltip(string pointFormat)
        {
            PointFormat = pointFormat;
        }
    }
}
