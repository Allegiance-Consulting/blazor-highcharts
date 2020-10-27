using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Label
    {
        [JsonProperty("connectorAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConnectorAllowed { get; set; }
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public string Align { get; set; }
        [JsonProperty("textAlign", NullValueHandling = NullValueHandling.Ignore)]
        public string TextAlign { get; set; }
        [JsonProperty("verticalAlign", NullValueHandling = NullValueHandling.Ignore)]
        public string VerticalAlign { get; set; }
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y { get; set; }
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public double? X { get; set; }
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public Style Style { get; set; }

        public Label()
        {

        }

        public Label(bool? connectorAllowed = null)
        {
            ConnectorAllowed = connectorAllowed;
        }
    }
}