using Newtonsoft.Json;
using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class Datum
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y { get; set; }
        
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public double? X { get; set; }
        
        [JsonProperty("drilldown", NullValueHandling = NullValueHandling.Ignore)]
        public string Drilldown { get; set; }

        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
        public string Radius { get; set; }

        [JsonProperty("innerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public string InnerRadius { get; set; }

        //[JsonProperty("borderRadius", NullValueHandling = NullValueHandling.Ignore)]
        //public string BorderRadius { get; set; }

        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public Marker Marker { get; set; }

        public Datum()
        {

        }
    }
}
