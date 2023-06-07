namespace FigureCaclulatorExtentions
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            if(_radius < 0)
            {
                // TODO : add logger
                return 0;
            }

            return Math.PI * Math.Pow(_radius, 2);
        }

        private double _radius;
    }
}