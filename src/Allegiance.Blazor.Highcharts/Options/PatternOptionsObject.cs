using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PatternOptionsObject
    {
        [JsonProperty("aspectRatio", NullValueHandling = NullValueHandling.Ignore)]
        public double? AspectRatio { get; set; }
        [JsonProperty("backgroundColor", NullValueHandling = NullValueHandling.Ignore)]
        public string? BackgroundColor { get; set; }
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string? Color { get; set; }
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; }
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string? Image { get; set; }
        [JsonProperty("opacity  ", NullValueHandling = NullValueHandling.Ignore)]
        public double? Opacity { get; set; }
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string? Path { get; set; }
        [JsonProperty("patternTransform", NullValueHandling = NullValueHandling.Ignore)]
        public string? PatternTransform { get; set; }
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public double? X { get; set; }
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y { get; set; }


    }
}
