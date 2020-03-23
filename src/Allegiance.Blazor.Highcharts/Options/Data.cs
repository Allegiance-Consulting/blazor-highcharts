using Newtonsoft.Json;
using System.Collections.Generic;
using Allegiance.Blazor.Highcharts.Attributes;
using System;



namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Data
    {
        public Data(List<long?> data) { ArrayData = data; }

        //public Data(object[,] data) { DoubleArrayData = data; }

        //public Data(Point[] data) { Points = data; }

        //public Data(SeriesData[] data) { SeriesData = data; }
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        //[Name("data")]
        public List<long?> ArrayData { get; private set; }

        //[JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        //public object[,] DoubleArrayData { get; private set; }
        //ToDo
        //[JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        //public Point[] Points { get; private set; }

        //[JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        //public SeriesData[] SeriesData { get; private set; }

    }
}
