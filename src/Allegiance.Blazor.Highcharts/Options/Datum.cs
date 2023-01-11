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

        public Datum(string name, double? y, string drilldown = null, string color = null, string radius = null, string innerRadius = null, Marker marker = null)
        {
            Name = name;
            Y = y;
            Drilldown = drilldown;
            Radius = radius;
            InnerRadius = innerRadius;
            Color = color;
            Marker = marker;
        }
    }
}
