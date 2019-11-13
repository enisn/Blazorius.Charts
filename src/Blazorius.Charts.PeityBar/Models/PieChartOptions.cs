namespace Blazorius.Charts.Peity.Models
{
    public class PieChartOptions : OptionsBase
    {
        private double? radius;

        public double? Radius { get => radius; set => SetProperty(ref radius, value); }
    }
}
