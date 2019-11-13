using Blazorius.Charts.Peity.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorius.Charts.Peity
{
    public static class Startup
    {
        public static IServiceCollection AddPeityCharts(this IServiceCollection services)
        {
            return services.AddTransient<IPeityInterop, PeityInterop>();
        }
    }
}
