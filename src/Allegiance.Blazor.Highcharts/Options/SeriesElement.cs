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
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public Marker Marker { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Data { get; set; }
        [JsonProperty("colorByPoint", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ColorByPoint { get; set; }
        [JsonProperty("showInLegend", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowInLegend { get; set; }
        [JsonProperty("lineWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? LineWidth { get; set; }
        [JsonProperty("lineColor", NullValueHandling = NullValueHandling.Ignore)]
        public string LineColor { get; set; }
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }
        [JsonProperty("innerSize", NullValueHandling = NullValueHandling.Ignore)]
        public string InnerSize { get; set; }
        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }
        [JsonProperty("stack", NullValueHandling = NullValueHandling.Ignore)]
        public string Stack { get; set; }

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