using Newtonsoft.Json;
using System.Collections.Generic;


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

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public string  Width { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public string Height { get; set; }

        [JsonProperty("spacing", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Spacing { get; set; }

        [JsonProperty("margin", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Margin { get; set; }

        [JsonProperty("backgroundColor")]
        public object BackgroundColor { get; set; }

        [JsonProperty("animation", NullValueHandling = NullValueHandling.Ignore)]
        public Animation Animation { get; set; }

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
