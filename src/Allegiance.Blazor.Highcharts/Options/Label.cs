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
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        public Label()
        {

        }

        public Label(bool? connectorAllowed = null)
        {
            ConnectorAllowed = connectorAllowed;
        }
    }
}