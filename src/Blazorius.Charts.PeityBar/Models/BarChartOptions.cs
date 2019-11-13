namespace Blazorius.Charts.Peity.Models
{
    public class BarChartOptions : OptionsBase
    {
        private int? max;
        private int? min;
        private float? padding;

        public int? Max { get => max; set => SetProperty(ref max, value); }
        public int? Min { get => min; set => SetProperty(ref min, value); }
        public float? Padding { get => padding; set => SetProperty(ref padding, value); }
    }
}
