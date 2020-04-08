using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptions
    {
        [JsonProperty("series", NullValueHandling = NullValueHandling.Ignore)]
        public PlotOptionsSeries Series { get; set; }

        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public Area Area { get; set; }

        [JsonProperty("pie", NullValueHandling = NullValueHandling.Ignore)]
        public Pie Pie { get; set; }
        [JsonProperty("scatter", NullValueHandling = NullValueHandling.Ignore)]
        public Scatter Scatter { get; set; }

        [JsonProperty("column", NullValueHandling = NullValueHandling.Ignore)]
        public Column Column { get; set; }
        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public Line Line { get; set; }

        [JsonProperty("solidgauge", NullValueHandling = NullValueHandling.Ignore)]
        public Solidgauge Solidgauge { get; set; }



        public PlotOptions()
        {
            Series = new PlotOptionsSeries();
        }

        public PlotOptions(PlotOptionsSeries series = null)
        {
            Series = series;
        }
        public PlotOptions(PlotOptionsSeries series = null, Area area = null)
        {
            Series = series;
            Area = area;
        }
        public PlotOptions(PlotOptionsSeries series = null, Pie pie = null)
        {
            Series = series;
            Pie = pie;
        }

        public PlotOptions(PlotOptionsSeries series = null , Column column = null)
        {
            Series = series;
            Column = column;
        }
    }
}
