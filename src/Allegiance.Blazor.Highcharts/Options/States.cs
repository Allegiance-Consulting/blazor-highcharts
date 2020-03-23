using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class States
    {
        [JsonProperty("hover", NullValueHandling = NullValueHandling.Ignore)]
        public Hover Hover { get; set; }

        public States()
        {

        }

        public States(Hover hover = null)
        {
            Hover = hover;
        }
    }
}