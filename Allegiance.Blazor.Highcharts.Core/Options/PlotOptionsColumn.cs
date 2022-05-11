using Newtonsoft.Json;


namespace Allegiance.Blazor.Highcharts.Core.Options
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

        public PlotOptionsColumn(string stacking)
        {
            Stacking = stacking;
        }

        public PlotOptionsColumn(int? borderRadius)
        {
            BorderRadius = borderRadius;
        }
    }
}
