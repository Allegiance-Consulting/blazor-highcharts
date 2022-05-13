using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class ContextButton
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        public ContextButton(bool? enabled = null)
        {
            Enabled = enabled;
        }
    }

}
