using Newtonsoft.Json;
using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class SeriesElement
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Data { get; set; }

        public SeriesElement()
        {

        }

        public SeriesElement(string name = null, List<object> data = null)
        {
            Name = name;
            Data = data;
        }
    }
}