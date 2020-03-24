using Newtonsoft.Json;
using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class SeriesElement
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Data { get; set; }
        [JsonProperty("colorByPoint", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ColorByPoint { get; set; }

        public SeriesElement()
        {

        }

        public SeriesElement(string name = null, List<object> data = null, string type = null, bool? colorbypoint = null)
        {
            Name = name;
            Data = data;
            Type = type;
            ColorByPoint = colorbypoint;
        }
    }
}