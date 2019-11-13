using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorius.Charts.Peity.Models
{
    public class DonutChartOptions : PieChartOptions
    {
        private double? innerRadius;

        public double? InnerRadius { get => innerRadius; set => SetProperty(ref innerRadius, value); }
    }
}
