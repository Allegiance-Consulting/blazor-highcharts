using Newtonsoft.Json;


namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Column
    {
        [JsonProperty("borderRadius", NullValueHandling = NullValueHandling.Ignore)]
        public int? BorderRadius { get; set; }

        public Column()
        {

        }

        public Column(int? borderRadius)
        {
            BorderRadius = borderRadius;
        }
    }
}
