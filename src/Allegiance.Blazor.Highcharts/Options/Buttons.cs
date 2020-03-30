using Newtonsoft.Json;


namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Buttons
    {
        [JsonProperty("contextButton", NullValueHandling = NullValueHandling.Ignore)]
        public ContextButton ContextButton { get; set; }
    }
}
