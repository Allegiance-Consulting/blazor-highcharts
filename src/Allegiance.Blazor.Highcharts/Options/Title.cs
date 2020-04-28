using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Title
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }
        [JsonProperty("useHTML", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseHTML { get; set; }

        [JsonProperty("verticalAlign", NullValueHandling = NullValueHandling.Ignore)]
        public string VerticalAlign { get; set; }
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public string Align { get; set; }

        [JsonProperty("floating", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Floating { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public Style Style { get; set; }

        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public long? Y { get; set; }
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public long? X { get; set; }

        public Title()
        {

        }
        public Title( bool? enabled = null)
        {
            Enabled = enabled;
        }

        public Title(string text = null)
        {
            Text = text;
        }
    }
}