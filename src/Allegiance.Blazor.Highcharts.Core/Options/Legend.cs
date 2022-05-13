using Newtonsoft.Json;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class Legend
    {
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public string Align { get; set; }
        [JsonProperty("alignColumns", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlignColumns { get; set; }
        [JsonProperty("backgroundColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundColor { get; set; }
        [JsonProperty("borderColor", NullValueHandling = NullValueHandling.Ignore)]
        public string BorderColor { get; set; }
        [JsonProperty("borderRadius", NullValueHandling = NullValueHandling.Ignore)]
        public int? BorderRadius { get; set; }
        [JsonProperty("borderWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? BorderWidth { get; set; }
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }
        [JsonProperty("floating", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Floating { get; set; }
        [JsonProperty("itemDistance", NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemDistance { get; set; }
        [JsonProperty("itemMarginBottom", NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemMarginBottom { get; set; }
        [JsonProperty("itemMarginTop", NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemMarginTop { get; set; }
        [JsonProperty("itemWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemWidth { get; set; }
        [JsonProperty("labelFormat", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelFormat { get; set; }
        [JsonProperty("layout", NullValueHandling = NullValueHandling.Ignore)]
        public string Layout { get; set; }
        [JsonProperty("margin", NullValueHandling = NullValueHandling.Ignore)]
        public int? Margin { get; set; }
        [JsonProperty("maxHeight", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxHeight { get; set; }
        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore)]
        public int? Padding { get; set; }
        [JsonProperty("reversed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reversed { get; set; }
        [JsonProperty("rtl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rtl { get; set; }
        [JsonProperty("shadow", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shadow { get; set; }
        [JsonProperty("squareSymbol", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SquareSymbol { get; set; }
        [JsonProperty("symbolHeight", NullValueHandling = NullValueHandling.Ignore)]
        public int? SymbolHeight { get; set; }
        [JsonProperty("symbolPadding", NullValueHandling = NullValueHandling.Ignore)]
        public int? SymbolPadding { get; set; }
        [JsonProperty("symbolRadius", NullValueHandling = NullValueHandling.Ignore)]
        public int? SymbolRadius { get; set; }
        [JsonProperty("symbolWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? SymbolWidth { get; set; }
        [JsonProperty("title ", NullValueHandling = NullValueHandling.Ignore)]
        public Title Title { get; set; }
        [JsonProperty("useHTML", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseHTML { get; set; }
        [JsonProperty("verticalAlign", NullValueHandling = NullValueHandling.Ignore)]
        public string VerticalAlign { get; set; }
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public int? X { get; set; }
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public int? Y { get; set; }

        public Legend(bool? enabled = null, string layout = null, string align = null, string verticalAlign = null, bool? floating = null, int? x = null, int? y = null, int? borderWidth = null)
        {
            Enabled = enabled;
            Floating = floating;
            Layout = layout;
            Align = align;
            VerticalAlign = verticalAlign;
            X = x;
            Y = y;
            BorderWidth = borderWidth;
        }

        public Legend()
        {

        }
    }
}
