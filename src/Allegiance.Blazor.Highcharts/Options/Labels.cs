using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Options
{
    // Not sure if this is the same as Label class, will investigate futher. Leaving for now
    public partial class Labels
    {
        [JsonProperty("formatter", NullValueHandling = NullValueHandling.Ignore)]
        public string Formatter { get; set; }

        public Labels()
        {

        }

        public Labels(string formatter)
        {
            Formatter = formatter;
            // So the temporary workaround to pass actual javascript functions
            // is to write them as function() {}
            // the reviver on javascript side will look at this style and then convert
            // it into a new Function(replaceTextFunction);
            // Don't love this workaround, will investigate for something better.
            // The reasoning behind this is dotnet is already reviving any object 
            // passed as an argument to blazor as JSON string and then casting to a object again.
        }
    }
}