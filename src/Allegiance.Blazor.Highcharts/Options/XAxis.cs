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

        public XAxis()
        {

        }

        public XAxis(Accessibility accessibility = null, Labels labels = null, bool? allowDecimals = null)
        {
            Accessibility = accessibility;
            Labels = labels;
            AllowDecimals = allowDecimals;
        }
    }
}