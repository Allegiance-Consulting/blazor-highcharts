using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Accessibility
    {
        [JsonProperty("rangeDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string RangeDescription { get; set; }

        public Accessibility()
        {

        }

        public Accessibility(string rangeDescription)
        {
            RangeDescription = rangeDescription;
        }
    }
}