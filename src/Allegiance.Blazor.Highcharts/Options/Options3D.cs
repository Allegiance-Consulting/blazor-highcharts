using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public class Options3D
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }
        [JsonProperty("alpha", NullValueHandling = NullValueHandling.Ignore)]
        public int? Alpha { get; set; }
        [JsonProperty("beta", NullValueHandling = NullValueHandling.Ignore)]
        public int? Beta { get; set; }

        public Options3D()
        {
        }

        // TODO find another solution here to simplify ctor.
        public Options3D(bool? enabled = null, int? alpha = null, int? beta = null)
        {
            Enabled = enabled;
            Alpha = alpha;
            Beta = beta;
        }
    }
}
