using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class XAxis
    {
        [JsonProperty("accessibility", NullValueHandling = NullValueHandling.Ignore)]
        public Accessibility Accessibility { get; set; }

        [JsonProperty("allowDecimals", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowDecimals { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Labels Labels { get; set; }
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        public XAxis()
        {

        }

        public XAxis(Accessibility accessibility = null, Labels labels = null, bool? allowDecimals = null, string type = null)
        {
            Accessibility = accessibility;
            Labels = labels;
            AllowDecimals = allowDecimals;
            Type = type;

        }

        public XAxis(string type =null)
        {
            Type = type;
        }
    }
}