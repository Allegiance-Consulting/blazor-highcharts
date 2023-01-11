using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class Condition
    {
        [JsonProperty("maxWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxWidth { get; set; }

        public Condition()
        {

        }

        public Condition(int? maxWidth = null)
        {
            MaxWidth = maxWidth;
        }
    }
}