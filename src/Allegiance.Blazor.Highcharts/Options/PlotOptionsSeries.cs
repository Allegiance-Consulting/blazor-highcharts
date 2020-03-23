using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptionsSeries
    {
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public Label Label { get; set; }

        [JsonProperty("pointStart", NullValueHandling = NullValueHandling.Ignore)]
        public long? PointStart { get; set; }

        public PlotOptionsSeries()
        {

        }

        public PlotOptionsSeries(Label label = null, long? pointStart = null)
        {
            Label = label;
            PointStart = pointStart;
        }
    }
}
