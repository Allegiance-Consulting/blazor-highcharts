using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class Rule
    {
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public Condition Condition { get; set; }

        [JsonProperty("chartOptions", NullValueHandling = NullValueHandling.Ignore)]
        public ChartOptions ChartOptions { get; set; }

        public Rule()
        {

        }

        public Rule(Condition condition = null, ChartOptions chartOptions = null)
        {
            Condition = condition;
            ChartOptions = chartOptions;
        }
    }
}