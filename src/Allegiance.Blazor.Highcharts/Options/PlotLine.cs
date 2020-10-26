using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotLine
    {

        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; } = "red";
        [JsonProperty("dashStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string DashStyle { get; set; } = Allegiance.Blazor.Highcharts.Constants.DashStyle.LongDashDot;
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; } = 1;
        [JsonProperty("zIndex", NullValueHandling = NullValueHandling.Ignore)]
        public int? ZIndex { get; set; } = 5;
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public Label Label { get; set; }
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }


        public PlotLine()
        {

        }
    }
}
