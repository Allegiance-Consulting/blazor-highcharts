using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class YAxis
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public Title Title { get; set; }

        public YAxis()
        {

        }

        public YAxis(Title title)
        {
            Title = title;
        }
    }
}