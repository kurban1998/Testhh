namespace FigureCaclulatorExtentions
{
    public class Triangle : IFigure
    {
        public Triangle(double sideA, double sideB, double sideC) 
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea()
        {
            if(!IsTriangle())
            {
                // TODO : add logger
                return 0;
            }
            else
            {
                double perimeter = (_sideA + _sideB + _sideC) / 2;
                return Math.Sqrt(perimeter * (perimeter - _sideA) * (perimeter - _sideB) * (perimeter - _sideC));
            }
        }

        public bool IsRectangular()
        {
            if (Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) == Math.Pow(_sideC, 2) ||
                Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2) == Math.Pow(_sideB, 2) ||
                Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2) == Math.Pow(_sideA, 2))
            {
                return true;
            }

            return false;
        }

        private bool IsTriangle()
        {
            if (_sideA + _sideB > _sideC &&
                _sideA + _sideC > _sideB &&
                _sideB + _sideC > _sideA)
            {
                return true;
            }

            return false;
        }

        private double _sideA;
        private double _sideB;
        private double _sideC;
    }
}