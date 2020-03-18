using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
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

        public Rule(Condition condition, ChartOptions chartOptions)
        {
            Condition = condition;
            ChartOptions = chartOptions;
        }
    }
}