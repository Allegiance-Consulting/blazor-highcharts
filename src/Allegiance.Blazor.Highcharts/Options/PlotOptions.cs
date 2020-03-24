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

        public PlotOptions()
        {

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
    }
}
