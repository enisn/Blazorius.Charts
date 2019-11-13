using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorius.Charts.Peity.Models
{
    public class BarChartOptions
    {
        public string Delimiter { get; set; } = ",";
        public string[] Fill { get; set; }
        public int? Height { get; set; }
        public int? Max { get; set; }
        public int? Min { get; set; }
        public float? Padding { get; set; }
        public int? Width { get; set; }
    }
}
