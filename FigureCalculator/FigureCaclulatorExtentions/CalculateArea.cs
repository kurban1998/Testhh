namespace FigureCaclulatorExtentions
{
    public class CalculateArea
    {
        public CalculateArea(params IFigure[] figures) 
        {
            _figures = figures;
        }

        public IEnumerable<double> CalculateSquare()
        {
            foreach (var figure in _figures)
            {
                yield return figure.CalculateArea();
            }
        }

        private readonly IFigure[] _figures;
    }
}