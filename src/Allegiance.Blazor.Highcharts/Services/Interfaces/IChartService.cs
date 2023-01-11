using System.Threading.Tasks;

namespace Allegiance.Blazor.Highcharts.Core.Services.Interfaces
{
    public interface IChartService
    {
        Task RenderChart(string containerId, string chartOptions);
    }
}