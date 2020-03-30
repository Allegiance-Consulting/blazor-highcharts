using Newtonsoft.Json;


namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Credits
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        public Credits()
        {

        }

        public Credits(bool? enabled = null)
        {
            Enabled = enabled;
        }
    }
}
