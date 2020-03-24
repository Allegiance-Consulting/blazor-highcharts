using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptionsSeries
    {
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public Label Label { get; set; }

        [JsonProperty("pointStart", NullValueHandling = NullValueHandling.Ignore)]
        public long? PointStart { get; set; }
        [JsonProperty("pointWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? PointWidth { get; set; }

        public PlotOptionsSeries()
        {

        }

        public PlotOptionsSeries(Label label = null, long? pointStart = null, int? pointwidth = null)
        {
            Label = label;
            PointStart = pointStart;
            PointWidth = pointwidth;
        }
    }
}
