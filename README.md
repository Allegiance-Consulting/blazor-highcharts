# blazor-highcharts
Blazor Wrapper for Highcharts library

A Demo can be found https://allegiance-consulting.github.io/blazor-highcharts/

### Quick Installation Guide

Install Package.

Add the following to `_Imports.razor`
```razor
@using Allegiance.Blazor.Highcharts.Charts;
@using Allegiance.Blazor.Highcharts.Options;
@using Allegiance.Blazor.Highcharts.Constants;
@using Allegiance.Blazor.Highcharts.Services;
```
Add the following to `index.html`
```razor
    <script src="_content/Allegiance.Blazor.Highcharts/scripts/blazor-highcharts.js"></script>
    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script src="https://code.highcharts.com/highcharts-more.js"></script>
    <script src="https://code.highcharts.com/modules/series-label.js"></script>
    <script src="https://code.highcharts.com/modules/solid-gauge.js"></script>
    <script src="https://code.highcharts.com/modules/exporting.js"></script>
    <script src="https://code.highcharts.com/modules/export-data.js"></script>
    <script src="https://code.highcharts.com/modules/accessibility.js"></script>
```
Add the following to the relevant sections of `Program.cs`
```c#
using Allegiance.Blazor.Highcharts.Services;
```
```c#
builder.Services.AddSingleton<IChartService, ChartService>();
```
### Usage
```razor
@using Allegiance.Blazor.Highcharts.Charts
@using Allegiance.Blazor.Highcharts.Options

@inject IChartService chartService
@inject IJSRuntime jsRuntime
@implements IDisposable

<div id="basicLine"></div>

@code {

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
        if (firstRender)
        {
            chartService.RenderChart("basicLine", BasicLineGraph.Generate());
        }
    }

    private ChartObject BasicLineGraph = new ChartObject()
    {
        Series = new List<SeriesElement>()
              {
              new SeriesElement("Series Element 1", new List<object>(){
                    1, 10, 20, 30, 40, 50, 60, 70
                  }),
              new SeriesElement("Series Element 2", new List<object>(){
                80, 40, 20, 10, 5, 2.5, 1.25, 0.625
                  }),
              new SeriesElement("Series Element 3", new List<object>(){
                80/(10^7), 80/(10^6), 80/(10^5), 80/(10^4),80/(10^3), 80/(10^2), 80/(10^1), 80/(10^0)
                  }),
              new SeriesElement("Series Element 4", new List<object>(){
                20,40,10,60,30,50,20,40
                  })
              },
        Title = new Title("Thisd is the Tittle"),
        Subtitle = new Title("This is the Subtitle"),
        YAxis = new YAxis(
           new Title("Title of Y-axis")
           ),
        XAxis = new XAxis(
           new Accessibility("Title of Y-axis")
           )
    };

    public void Dispose()
    {
        BasicLineGraph.DisposeChart(jsRuntime, "basicLine");
    }
}
```
