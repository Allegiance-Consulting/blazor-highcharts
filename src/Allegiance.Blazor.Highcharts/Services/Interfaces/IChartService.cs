using System.Threading.Tasks;

namespace Allegiance.Blazor.Highcharts.Services
{
    public interface IChartService
    {
        Task RenderChart(string containerId, string chartOptions);
    }
}