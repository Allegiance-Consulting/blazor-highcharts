using Newtonsoft.Json;


namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Buttons
    {
        [JsonProperty("contextButton", NullValueHandling = NullValueHandling.Ignore)]
        public ContextButton ContextButton { get; set; }

        public Buttons()
        {

        }

        public Buttons(bool? contextButtonEnabled)
        {
            ContextButton = new ContextButton(contextButtonEnabled);
        }
    }
}
