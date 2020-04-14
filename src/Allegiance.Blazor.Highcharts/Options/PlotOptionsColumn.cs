using Newtonsoft.Json;


namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptionsColumn
    {
        [JsonProperty("borderRadius", NullValueHandling = NullValueHandling.Ignore)]
        public int? BorderRadius { get; set; }

        [JsonProperty("stacking", NullValueHandling = NullValueHandling.Ignore)]
        public string Stacking { get; set; }

        public PlotOptionsColumn()
        {

        }

        public PlotOptionsColumn(int? borderRadius)
        {
            BorderRadius = borderRadius;
        }
    }
}
