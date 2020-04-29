using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class PlotOptionsPie
    {
        [JsonProperty("allowPointSelect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowPointSelect { get; set; }

        [JsonProperty("showInLegend", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowInLegend { get; set; }
        [JsonProperty("borderColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderColor { get; set; }
        [JsonProperty("borderWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int BorderWidth { get; set; }

        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public string Cursor { get; set; }
        [JsonProperty("center", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Center { get; set; }

        [JsonProperty("dataLabels", NullValueHandling = NullValueHandling.Ignore)]
        public Labels DataLabels { get; set; }

        [JsonProperty("states", NullValueHandling = NullValueHandling.Ignore)]
        public States States { get; set; }

        public PlotOptionsPie()
        {

        }

        public PlotOptionsPie(bool? allowpointselect = null, bool? showinlegend = null, string cursor = null, Labels datalabels = null, States states = null)
        {
            AllowPointSelect = allowpointselect;
            ShowInLegend = showinlegend;
            Cursor = cursor;
            DataLabels = datalabels;
            States = states;
        }




    }
}