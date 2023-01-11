using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class ChartOptions
    {
        [JsonProperty("legend", NullValueHandling = NullValueHandling.Ignore)]
        public Legend Legend { get; set; }
        [JsonProperty("subtitle")]
        public Title Subtitle { get; set; }

        public ChartOptions()
        {

        }

        public ChartOptions(Legend legend = null)
        {
            Legend = legend;
        }
    }
}