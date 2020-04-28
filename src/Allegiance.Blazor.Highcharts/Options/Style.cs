using Newtonsoft.Json;
using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Style
    {
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public string FontWeight { get; set; }

        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public string FontSize { get; set; }

        [JsonProperty("fontFamily", NullValueHandling = NullValueHandling.Ignore)]
        public string FontFamily { get; set; }
        [JsonProperty("textAlign", NullValueHandling = NullValueHandling.Ignore)]
        public string TextAlign { get; set; }

    }
}
