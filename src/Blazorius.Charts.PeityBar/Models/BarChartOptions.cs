namespace Blazorius.Charts.Peity.Models
{
    public class BarChartOptions : OptionsBase
    {
        private double? max;
        private double? min;
        private float? padding;

        public double? Max { get => max; set => SetProperty(ref max, value); }
        public double? Min { get => min; set => SetProperty(ref min, value); }
        public float? Padding { get => padding; set => SetProperty(ref padding, value); }
    }
}
