using Newtonsoft.Json;
using System.Collections.Generic;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class Responsive
    {
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<Rule> Rules { get; set; }

        public Responsive()
        {

        }

        public Responsive(Rule rule)
        {
            Rules = new List<Rule>() { rule };
        }

        public Responsive(List<Rule> rules = null)
        {
            Rules = rules;
        }
    }
}