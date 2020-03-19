using Allegiance.Blazor.Highcharts.Charts;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Allegiance.Blazor.Highcharts.Services
{
    public class ChartService : IChartService
    {
        private readonly IJSRuntime jSRuntime;
        public ChartService(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }

        public async Task RenderChart(string containerId, string chartOptions)
        {
            await jSRuntime.InvokeVoidAsync("renderHighchartChart", containerId, chartOptions);
        }
    }
}
