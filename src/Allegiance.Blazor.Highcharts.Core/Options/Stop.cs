using System;
using System.Collections.Generic;
using System.Text;

namespace Allegiance.Blazor.Highcharts.Core.Options
{
    public partial class Stop
    {
        public double? Value { get; set; }
        public string Color { get; set; }

        public Stop(double? value, string color)
        {
            Value = value;
            Color = color;
        }
    }
}
