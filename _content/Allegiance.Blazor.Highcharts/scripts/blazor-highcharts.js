// This is the interop Javascript file that handles all interop between Blazor and Javascript

window.renderHighchartChart = function (containerId, chartOptions) {
    //debugger
    let options = '';
    try {
        options = JSON.parse(chartOptions, this.reviver);
    } catch (e) {
        console.log(`You might have a syntax error in your function call from Blazor`);
        this.console.log(e.message);
        this.console.log(e.stack);
    }
    Highcharts.chart(containerId, options);
}

window.updateSeriesHighchartChart = function (containerId, seriesData) {

    for (var i = 0; i < Highcharts.charts.length; i++) {
        if (Highcharts.charts[i].renderTo.id === containerId && document.getElementById(Highcharts.charts[i].container.id) != null) {
            Highcharts.charts[i].series[0].setData(seriesData);
            break;
        }
    }
}
window.updateSeriesAtIndexHighchartChart = function (containerId, seriesIndex, seriesData) {
    for (var i = 0; i < Highcharts.charts.length; i++) {
        if (Highcharts.charts[i].renderTo.id === containerId && document.getElementById(Highcharts.charts[i].container.id) != null) {
            Highcharts.charts[i].series[seriesIndex].setData(seriesData);
            break;
        }
    }
}
window.updateTitleHighchartChart = function (containerId, titleText, titleColor) {
    for (var i = 0; i < Highcharts.charts.length; i++) {
        if (Highcharts.charts[i].renderTo.id === containerId && document.getElementById(Highcharts.charts[i].container.id) != null) {
            Highcharts.charts[i].update({
                title: {
                    text: titleText,
                    style: {
                        color: titleColor
                    }
                }
            });
            break;
        }
    }
}

window.destroyCharts = function () {
    for (var i = 0; i < Highcharts.charts.length; i++) {
        if (Highcharts.charts[i]) {
            Highcharts.charts[i].destroy();
        }
    }
    const x = Number(Highcharts.chart.length);
    for (var i = 0; i <= x; i++) {
        Highcharts.charts.pop(0);

    }
}

window.disposeHighchartChart = function (containerId) {
    let count = -1;
    let shouldPop = false;
    for (var i = 0; i < Highcharts.charts.length; i++) {
        if (Highcharts.charts[i].renderTo.id === containerId) {
            Highcharts.charts[i].destroy();
            shouldPop = true;
            break;
        }
        count++;
    }
    if (shouldPop === true) {
        Highcharts.charts.pop(0);
    }
}


function reviver(key, value) {
    if (typeof (value) === 'string' && value.includes('function()')) {
        let regEx = new RegExp("{([^}]*)}");
        let func = new Function(value.split("function()")[1]);
        return func;
    }
    return value
    // So the temporary workaround to pass actual javascript functions
    // is to write them as function() {}
    // the reviver on javascript side will look at this style and then convert
    // it into a new Function(replaceTextFunction);
    // Don't love this workaround, will investigate for something better.
    // The reasoning behind this is dotnet is already reviving any object 
    // passed as an argument to blazor as JSON string and then casting to a object again.
}