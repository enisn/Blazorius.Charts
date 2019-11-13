using Blazorius.Charts.Peity.Models;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorius.Charts.Peity.Services
{
    public class PeityInterop : IPeityInterop
    {
        private const string INIT_EVENT = "InitPeityFromCs";

        private readonly IJSRuntime jSRuntime;

        public PeityInterop(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }

        public async Task InitBarAsync(string selector, BarChartOptions opts)
            => await InitAsync(ChartType.Bar, selector, opts);

        public async Task InitAsync(ChartType type, string selector, object options)
            => await jSRuntime.InvokeVoidAsync(INIT_EVENT, type.ToString().ToLowerInvariant(), selector, options);
    }
}
