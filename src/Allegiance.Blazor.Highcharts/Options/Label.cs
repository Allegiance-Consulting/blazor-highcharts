using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Label
    {
        [JsonProperty("connectorAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConnectorAllowed { get; set; }

        public Label()
        {

        }

        public Label(bool? connectorAllowed)
        {
            ConnectorAllowed = connectorAllowed;
        }
    }
}