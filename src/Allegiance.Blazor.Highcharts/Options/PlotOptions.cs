using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptions
    {
        [JsonProperty("series", NullValueHandling = NullValueHandling.Ignore)]
        public PlotOptionsSeries Series { get; set; }

        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public PlotOptionsArea Area { get; set; }
        [JsonProperty("bar", NullValueHandling = NullValueHandling.Ignore)]
        public PlotOptionsBar Bar { get; set; }

        [JsonProperty("pie", NullValueHandling = NullValueHandling.Ignore)]
        public PlotOptionsPie Pie { get; set; }
        [JsonProperty("scatter", NullValueHandling = NullValueHandling.Ignore)]
        public PlotOptionsScatter Scatter { get; set; }

        [JsonProperty("column", NullValueHandling = NullValueHandling.Ignore)]
        public PlotOptionsColumn Column { get; set; }
        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public PlotOptionsLine Line { get; set; }
        [JsonProperty("spline", NullValueHandling = NullValueHandling.Ignore)]
        public PlotOptionsSpline Spline { get; set; }

        [JsonProperty("solidgauge", NullValueHandling = NullValueHandling.Ignore)]
        public PlotOptionsSolidgauge Solidgauge { get; set; }



        public PlotOptions()
        {
            Series = new PlotOptionsSeries();
        }

        public PlotOptions(PlotOptionsSeries series = null)
        {
            Series = series;
        }
        public PlotOptions(PlotOptionsSeries series = null, PlotOptionsArea area = null)
        {
            Series = series;
            Area = area;
        }
        public PlotOptions(PlotOptionsSeries series = null, PlotOptionsPie pie = null)
        {
            Series = series;
            Pie = pie;
        }

        public PlotOptions(PlotOptionsSeries series = null , PlotOptionsColumn column = null)
        {
            Series = series;
            Column = column;
        }
    }
}
