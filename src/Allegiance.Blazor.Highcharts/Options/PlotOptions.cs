using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptions
    {
        [JsonProperty("series", NullValueHandling = NullValueHandling.Ignore)]
        public PlotOptionsSeries Series { get; set; }

        public PlotOptions()
        {

        }

        public PlotOptions(PlotOptionsSeries series)
        {
            Series = series;
        }
    }
}
