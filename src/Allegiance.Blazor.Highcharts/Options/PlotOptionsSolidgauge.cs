using Newtonsoft.Json;
using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptionsSolidgauge
    {
        [JsonProperty("dataLabels", NullValueHandling = NullValueHandling.Ignore)]
        public Labels DataLabels { get; set; }

        [JsonProperty("stickyTracking", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StickyTracking { get; set; }

        [JsonProperty("rounded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rounded { get; set; }
    }
}
