
<img width="25%" src="https://github.com/enisn/Blazorius.Charts/blob/master/content/Blazorius_512.png?raw=true"/>

# Blazorius.Charts

This library includes chart implementations for Blazor.

# Support

| Package | Implementation | NuGet |
| --- | --- | --- |
| Blazorius.Charts | _Abstractiýons_ |  ![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Blazorius.Charts?logo=nuget) |
| Blazorius.Charts.Peity | [benpickles/peity](https://github.com/benpickles/peity) |  ![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Blazorius.Charts.Peity?logo=nuget) |

# Installation

- Install NuGet package to your Blazor project from [NuGet](https://www.nuget.org/packages/Blazorius.Charts.Peity/).

- Go your **Startup.cs** and add following line:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddPeityCharts(); // <--- Add this line
}
```

- That's it! Ready to use.

# Usage

- Go your **.razor** page and use like below:

```razor
@page "/Chart"

@using  Blazorius.Charts.Peity.Components

<BarChart Data="@data" />

@code {

    int[] data = new int[]
    {
        5,10,3,8,3,16,6,7
    };
}
```

- You can set some options like that:

```razor
@page "/Chart"

@using  Blazorius.Charts.Peity.Components

<BarChart Data="@data" Width="720" Padding="0.1" Color="#ff7300" />

@code {

    int[] data = new int[]
    {
        5,10,3,8,3,16,6,7
    };
}
```

# Sample

<img src="https://github.com/enisn/Blazorius.Charts/blob/master/content/ScreenShot_00.png?raw=true"/>


```razor
@page "/"

@using Blazorius.Charts.Peity.Components

<BarChart Data="data" Width="180" Height="40" Fill="colors" Padding=".1f"/>

<hr />

<PieChart Data="data"  Width="180" Height="180" Fill="colors" />

<hr />

<DonutChart Data="data"  Width="180" Height="180" Fill="colors"/>

<hr />

<LineChart Data="data"  Width="180" Height="180" Color="#ff7300" StrokeColor="#ffc89c" />

<hr />


@code {

    string[] colors = new[] { "#ff7300", "#ffc89c" };

    int[] data = new int[]
    {
        5,10,3,8,3,16,6,7,4,6,4,9,1,5,6
    };
}
```