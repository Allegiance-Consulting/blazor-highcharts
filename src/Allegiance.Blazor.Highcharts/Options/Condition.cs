using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Condition
    {
        [JsonProperty("maxWidth", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxWidth { get; set; }

        public Condition()
        {

        }

        public Condition(long? maxWidth = null)
        {
            MaxWidth = maxWidth;
        }
    }
}