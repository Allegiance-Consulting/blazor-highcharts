using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class DrilldownSeries
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Data { get; set; }
        
        public DrilldownSeries(){}
        public DrilldownSeries(string name = null, string id = null, List<object> data = null){
            Name = name;
            Id = id;
            Data = data;
        }
    }
}