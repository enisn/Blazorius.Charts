namespace Blazorius.Charts.Peity.Models
{
    public class PieChartOptions : OptionsBase
    {
        private float? radius;
        private float? innerRadius;

        public float? Radius { get => radius; set => SetProperty(ref radius, value); }

        public float? InnerRadius { get => innerRadius; set => SetProperty(ref innerRadius, value); }
    }
}
