using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class ChartOptions
    {
        [JsonProperty("legend", NullValueHandling = NullValueHandling.Ignore)]
        public Legend Legend { get; set; }

        public ChartOptions()
        {

        }

        public ChartOptions(Legend legend)
        {
            Legend = legend;
        }
    }
}