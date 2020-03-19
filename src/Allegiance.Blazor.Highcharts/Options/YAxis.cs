using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class YAxis
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public Title Title { get; set; }
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Labels Labels { get; set; }

        public YAxis()
        {

        }

        public YAxis(Title title = null, Labels labels = null)
        {
            Title = title;
            Labels = labels;
        }
    }
}