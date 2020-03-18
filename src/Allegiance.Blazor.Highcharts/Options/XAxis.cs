using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class XAxis
    {
        [JsonProperty("accessibility", NullValueHandling = NullValueHandling.Ignore)]
        public Accessibility Accessibility { get; set; }

        public XAxis()
        {

        }

        public XAxis(Accessibility accessibility)
        {
            Accessibility = accessibility;
        }
    }
}