
namespace Samples.SOLID.LSP.Violation
{
    public class CalcArea
    {
        private static void GetRectangleArea(Rectangle rectangle)
        {
            Console.Clear();
            Console.WriteLine("Calc rectangle area");
            Console.WriteLine();
            Console.WriteLine(rectangle.Height + " * " + rectangle.Width);
            Console.WriteLine();
            Console.WriteLine(rectangle.Area);
            Console.ReadKey();
        }
        public static void Calc()
        {
            var square = new Square
            {
                Height = 10,
                Width = 5
            };
            GetRectangleArea(square);
        }
    }
}
