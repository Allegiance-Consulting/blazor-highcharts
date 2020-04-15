using Newtonsoft.Json;
using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Datum
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public long? Y { get; set; }

        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
        public string Radius { get; set; }

        [JsonProperty("innerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public string InnerRadius { get; set; }

        //[JsonProperty("borderRadius", NullValueHandling = NullValueHandling.Ignore)]
        //public string BorderRadius { get; set; }

        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        public Datum()
        {

        }

        public Datum(string name = null, long? y = null, string color = null)
        {
            Name = name;
            Y = y;
            Color = color;
        }
    }
}
