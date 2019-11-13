using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorius.Charts.Peity.Models
{
    public class LineChartOptions : OptionsBase
    {
        private int? max;
        private int? min;
        private string stroke;
        private double? strokeWidth;

        public int? Max { get => max; set => SetProperty(ref max, value); }

        public int? Min { get => min; set => SetProperty(ref min, value); }

        public string Stroke { get => stroke; set => SetProperty(ref stroke, value); }

        public double? StrokeWidth { get => strokeWidth; set => SetProperty(ref strokeWidth, value); }
    }
}
