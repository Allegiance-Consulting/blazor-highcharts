using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class Drilldown
    {

        [JsonProperty("series", NullValueHandling = NullValueHandling.Ignore)]
        public List<SeriesElement> Series { get; set; }
        public Drilldown(){
            Series = null;
        }
    }
}
