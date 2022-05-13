using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class PlotOptionsLine
    {
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public Marker Marker { get; set; }
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }
        [JsonProperty("dashStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string DashStyle { get; set; }
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public Label Label { get; set; }

        public PlotOptionsLine()
        {

        }
    }
}
