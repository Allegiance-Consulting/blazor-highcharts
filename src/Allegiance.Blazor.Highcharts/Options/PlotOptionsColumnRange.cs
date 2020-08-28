using Newtonsoft.Json;


namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptionsColumnRange
    {
        [JsonProperty("borderRadius", NullValueHandling = NullValueHandling.Ignore)]
        public int? BorderRadius { get; set; }

        public PlotOptionsColumnRange()
        {

        }



        public PlotOptionsColumnRange(int? borderRadius)
        {
            BorderRadius = borderRadius;
        }
    }
}
