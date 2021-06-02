using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class DataLabels
    {
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public string Align { get; set; }
        [JsonProperty("allowOverlap", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowOverlap { get; set; }
        [JsonProperty("backgroundColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundColor { get; set; }
        [JsonProperty("borderColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderColor { get; set; }
        [JsonProperty("borderRadius", NullValueHandling = NullValueHandling.Ignore)]
        public int? BorderRadius { get; set; }
        [JsonProperty("borderWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? BorderWidth { get; set; }
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }
        [JsonProperty("crop", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Crop { get; set; }
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }
        [JsonProperty("inside", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inside { get; set; }
        [JsonProperty("overflow", NullValueHandling = NullValueHandling.Ignore)]
        public string Overflow { get; set; }
        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore)]
        public int? Padding { get; set; }
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }
        [JsonProperty("rotation", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rotation { get; set; }
        [JsonProperty("shaddow", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shaddow { get; set; }
        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
        public string Shape { get; set; }
        [JsonProperty("verticalAlign", NullValueHandling = NullValueHandling.Ignore)]
        public string VerticalAlign { get; set; }
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public int? X { get; set; }
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public int? Y { get; set; }
        [JsonProperty("z", NullValueHandling = NullValueHandling.Ignore)]
        public int? Z { get; set; }
        public DataLabels()
        {

        }

        public DataLabels(bool? enabled = null)
        {
            Enabled = enabled;
        }
    }
}
