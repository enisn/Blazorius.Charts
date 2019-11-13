using Blazorius.Charts.Peity.Models;
using System.Threading.Tasks;

namespace Blazorius.Charts.Peity.Services
{
    public interface IPeityInterop
    {
        Task InitAsync(ChartType type, string selector, object options);
        Task InitBarAsync(string selector, BarChartOptions optsJson);
    }
}
