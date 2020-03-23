using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Pie
    {
        [JsonProperty("allowPointSelect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowPointSelect { get; set; }

        [JsonProperty("showInLegend", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowInLegend { get; set; }

        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public string Cursor { get; set; }

        [JsonProperty("dataLabels", NullValueHandling = NullValueHandling.Ignore)]
        public Legend DataLabels { get; set; }

        [JsonProperty("states", NullValueHandling = NullValueHandling.Ignore)]
        public States States { get; set; }

        public Pie()
        {

        }

        public Pie(bool? allowpointselect = null, bool? showinlegend = null, string cursor = null, Legend datalabels = null, States states = null)
        {
            AllowPointSelect = allowpointselect;
            ShowInLegend = showinlegend;
            Cursor = cursor;
            DataLabels = datalabels;
            States = states;
        }




    }
}