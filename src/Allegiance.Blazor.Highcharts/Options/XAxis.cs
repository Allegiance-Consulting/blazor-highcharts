using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class XAxis
    {
        [JsonProperty("accessibility", NullValueHandling = NullValueHandling.Ignore)]
        public Accessibility Accessibility { get; set; }

        [JsonProperty("allowDecimals", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowDecimals { get; set; }
        [JsonProperty("startOnTick", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StartOnTick { get; set; }
        [JsonProperty("endOnTick", NullValueHandling = NullValueHandling.Ignore)]
        public bool?EendOnTick { get; set; }
        [JsonProperty("showLastLabel", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowLastLabel { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Labels Labels { get; set; }
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public Title Title { get; set; }

        public XAxis()
        {

        }

        public XAxis(Accessibility accessibility=null, bool? allowDecimals=null, bool? startOnTick=null, bool? eendOnTick=null, bool? showLastLabel=null, Labels labels=null, string type=null, Title title = null)
        {
            Accessibility = accessibility;
            AllowDecimals = allowDecimals;
            StartOnTick = startOnTick;
            EendOnTick = eendOnTick;
            ShowLastLabel = showLastLabel;
            Labels = labels;
            Type = type;
            Title = title;
        }

        public XAxis(string type =null)
        {
            Type = type;
        }
    }
}