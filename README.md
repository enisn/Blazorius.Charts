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
```**
**
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

```html
@page "/Chart"

@using  Blazorius.Charts.Peity.Components
@using  Blazorius.Charts.Peity.Models

<BarChart Data="@data" Options="@options" />

@code {

    BarChartOptions options = new BarChartOptions
    {
        Fill = new[] { "#ff7300" },
        Width = 720,
        Padding = 0.1f,
    };

    int[] data = new int[]
    {
        5,10,3,8,3,16,6,7
    };
}
```