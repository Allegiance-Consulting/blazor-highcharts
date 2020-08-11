using Newtonsoft.Json;


namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Exporting
    {
        [JsonProperty("buttons", NullValueHandling = NullValueHandling.Ignore)]
        public Buttons Buttons { get; set; }

        [JsonProperty("sourceWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceWidth { get; set; }

        [JsonProperty("sourceHeight", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceHeight { get; set; }

        [JsonProperty("chartOptions", NullValueHandling = NullValueHandling.Ignore)]
        public ChartOptions ChartOptions { get; set; }

        public Exporting(Buttons buttons = null, int? sourceWidth = null, int? sourceHeight = null, ChartOptions chartOptions = null)
        {
            Buttons = buttons;
            SourceWidth = sourceWidth;
            SourceHeight = sourceHeight;
            ChartOptions = chartOptions;
        }

        public Exporting()
        {

        }
    }
}
