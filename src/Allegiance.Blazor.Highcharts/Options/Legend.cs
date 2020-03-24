using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Legend
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        [JsonProperty("layout", NullValueHandling = NullValueHandling.Ignore)]
        public string Layout { get; set; }

        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public string Align { get; set; }

        [JsonProperty("verticalAlign", NullValueHandling = NullValueHandling.Ignore)]
        public string VerticalAlign { get; set; }

        public Legend()
        {

        }

        public Legend(bool? enabled = null, string layout = null, string align = null, string verticalAlign = null)
        {
            Enabled = enabled;
            Layout = layout;
            Align = align;
            VerticalAlign = verticalAlign;
        }
    }
}
