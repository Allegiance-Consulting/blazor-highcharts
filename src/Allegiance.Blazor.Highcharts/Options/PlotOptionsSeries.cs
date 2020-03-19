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

        public PlotOptionsSeries(Label label, long? pointStart)
        {
            Label = label;
            PointStart = pointStart;
        }
    }
}
