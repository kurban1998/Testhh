using FigureCaclulatorExtentions;

namespace FigureСalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3,1,5);
            Circle circle = new Circle(3);

            var isRectangular = triangle.IsRectangular();

            CalculateArea calculateArea = new CalculateArea(triangle, circle);
            var square = calculateArea.CalculateSquare();
        }
    }
}