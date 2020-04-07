using System;
using System.Collections.Generic;
using System.Text;

namespace Allegiance.Blazor.Highcharts.Options
{
    public partial class Stop
    {
        public long? Value { get; set; }
        public string Color { get; set; }

        public Stop(long? value, string color)
        {
            Value = value;
            Color = color;
        }
    }
}
