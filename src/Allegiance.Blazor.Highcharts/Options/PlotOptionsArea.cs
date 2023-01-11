using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class PlotOptionsArea
    {
        [JsonProperty("pointStart", NullValueHandling = NullValueHandling.Ignore)]
        public double? PointStart { get; set; }
        [JsonProperty("stacking", NullValueHandling = NullValueHandling.Ignore)]
        public string Stacking { get; set; }
        [JsonProperty("lineWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? LineWidth { get; set; }
        [JsonProperty("lineColor", NullValueHandling = NullValueHandling.Ignore)]
        public string LineColor { get; set; }
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public Marker Marker { get; set; }
        [JsonProperty("dataLabels", NullValueHandling = NullValueHandling.Ignore)]
        public DataLabels DataLabels { get; set; }
        [JsonProperty("enableMouseTracking", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableMouseTracking { get; set; }

        public PlotOptionsArea()
        {

        }

        public PlotOptionsArea(double? pointStart = null, Marker marker = null)
        {
            PointStart = pointStart;
            Marker = marker;
        }
    }
}