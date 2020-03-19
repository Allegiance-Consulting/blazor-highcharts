// This is the interop Javascript file that handles all interop between Blazor and Javascript

window.renderHighchartChart = function (containerId, chartOptions) {
    options = JSON.parse(chartOptions);
    Highcharts.chart(containerId, options);
}