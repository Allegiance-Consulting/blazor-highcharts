using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Accessibility
    {
        [JsonProperty("rangeDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string? RangeDescription { get; set; }
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; }

        public Accessibility()
        {

        }

        // I added another param here for area charts to keep one accessibility class
        // TODO find another solution here to simplify ctor.
        public Accessibility(string? rangeDescription = null, string description = null)
        {
            RangeDescription = rangeDescription;
            Description = description;
        }
    }
}