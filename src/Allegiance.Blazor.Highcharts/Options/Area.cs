using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Area
    {
        [JsonProperty("pointStart", NullValueHandling = NullValueHandling.Ignore)]
        public long? PointStart { get; set; }

        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public Marker Marker { get; set; }

        public Area()
        {

        }

        public Area(long? pointStart, Marker marker)
        {
            PointStart = pointStart;
            Marker = marker;
        }
    }
}