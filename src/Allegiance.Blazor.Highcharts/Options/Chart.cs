using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Chart
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("styledmode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StyledMode { get; set; }
        [JsonProperty("zoomType", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoomType { get; set; }

        public Chart()
        {

        }

        public Chart(string type = null, bool? styledmode = null, string zoomtype = null)
        {
            Type = type;
            ZoomType = zoomtype;
            StyledMode = styledmode;
        }
    }
}
