using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class FillColorObject
    {
        [JsonProperty("animation", NullValueHandling = NullValueHandling.Ignore)]
        public bool Animation { get; set; }
        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public PatternOptionsObject? Pattern { get; set; }
        [JsonProperty("patternIndex", NullValueHandling = NullValueHandling.Ignore)]
        public int? PatterntIndex { get; set; }
    }  
}
