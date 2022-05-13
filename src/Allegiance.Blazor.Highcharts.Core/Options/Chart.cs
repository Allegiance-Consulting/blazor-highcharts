using Newtonsoft.Json;
using System.Collections.Generic;


namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class Chart
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("styledmode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StyledMode { get; set; }
        [JsonProperty("zoomType", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoomType { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        [JsonProperty("spacing", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Spacing { get; set; }

        [JsonProperty("margin", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Margin { get; set; }

        [JsonProperty("backgroundColor")]
        public object BackgroundColor { get; set; }

        [JsonProperty("animation", NullValueHandling = NullValueHandling.Ignore)]
        public Animation Animation { get; set; }

        [JsonProperty("options3d", NullValueHandling = NullValueHandling.Ignore)]
        public Options3D Options3d { get; set; }


        public Chart(string type = null, bool? styledMode = null, string zoomType = null, int? width = null, int? height = null, List<int?> spacing = null, List<int?> margin = null, object backgroundColor = null, Animation animation = null, Options3D options3d = null)
        {
            Type = type;
            StyledMode = styledMode;
            ZoomType = zoomType;
            Width = width;
            Height = height;
            Spacing = spacing;
            Margin = margin;
            BackgroundColor = backgroundColor;
            Animation = animation;
            Options3d = options3d;
        }

        public Chart()
        {

        }
    }
}
