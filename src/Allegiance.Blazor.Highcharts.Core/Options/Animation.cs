using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class Animation
    {
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }
        [JsonProperty("defer", NullValueHandling = NullValueHandling.Ignore)]
        public int? Defer { get; set; }
        public Animation()
        {

        }

        public Animation(int? duration)
        {
            Duration = duration;
        }
    }
}
