using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Animation
    {
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }
        public Animation()
        {

        }

        public Animation(int? duration)
        {
            Duration = duration;
        }
    }
}
