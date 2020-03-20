using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptions
    {
        [JsonProperty("series", NullValueHandling = NullValueHandling.Ignore)]
        public PlotOptionsSeries Series { get; set; }

        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public Area Area { get; set; }

        public PlotOptions()
        {

        }

        public PlotOptions(PlotOptionsSeries series = null, Area area = null)
        {
            Series = series;
            Area = area;
        }
    }
}
