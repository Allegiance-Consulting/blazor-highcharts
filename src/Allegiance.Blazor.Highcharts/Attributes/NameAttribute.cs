using System;
using System.Collections.Generic;
using System.Text;

namespace Allegiance.Blazor.Highcharts.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class NameAttribute : Attribute
    {
        public NameAttribute(string name) { Name = name; }
        public string Name { get; private set; }
    }
}
