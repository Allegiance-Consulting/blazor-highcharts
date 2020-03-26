using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class ContextButton
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }
    }
}
