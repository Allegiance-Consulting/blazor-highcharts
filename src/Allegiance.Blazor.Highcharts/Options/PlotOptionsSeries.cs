using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptionsSeries
    {
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public Label Label { get; set; }

        [JsonProperty("pointStart", NullValueHandling = NullValueHandling.Ignore)]
        public long? PointStart { get; set; }
        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public double? FillOpacity { get; set; }

        [JsonProperty("pointWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? PointWidth { get; set; }
        [JsonProperty("lineWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? LineWidth { get; set; }
        [JsonProperty("animation", NullValueHandling = NullValueHandling.Ignore)]
        public Animation Animation { get; set; }



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
