using Newtonsoft.Json;
using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class SeriesElement
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public long?[] Data { get; set; }

        public SeriesElement()
        {

        }

        public SeriesElement(string name, List<long?> data)
        {
            Name = name;
            Data = data.ToArray();
        }
    }
}