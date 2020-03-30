using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class YAxis
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public Title Title { get; set; }

        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public long? Min { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Labels Labels { get; set; }
        [JsonProperty("className", NullValueHandling = NullValueHandling.Ignore)]
        public string ClassName { get; set; }

        public YAxis()
        {

        }

        public YAxis(Title title = null, Labels labels = null, string classname = null)
        {
            Title = title;
            Labels = labels;
            ClassName = classname;
        }
    }
}