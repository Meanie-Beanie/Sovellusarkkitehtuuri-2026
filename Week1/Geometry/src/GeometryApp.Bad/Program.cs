using System;

namespace GeometryApp.Bad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Geometry calculator (bad version)");
            Console.Write("Shape (circle/rectangle): ");
            var shape = Console.ReadLine()?.Trim().ToLowerInvariant();

            if (shape == "circle")
            {
                Console.Write("Radius: ");
                var r = double.Parse(Console.ReadLine() ?? "0");
                var area = Math.PI * r * r;
                var perimeter = 2 * Math.PI * r;
                Console.WriteLine($"Area: {area:F2}");
                Console.WriteLine($"Perimeter: {perimeter:F2}");
            }
            else if (shape == "rectangle")
            {
                Console.Write("Width: ");
                var w = double.Parse(Console.ReadLine() ?? "0");
                Console.Write("Height: ");
                var h = double.Parse(Console.ReadLine() ?? "0");
                var area = w * h;
                var perimeter = 2 * (w + h);
                Console.WriteLine($"Area: {area:F2}");
                Console.WriteLine($"Perimeter: {perimeter:F2}");
            }
            else
            {
                Console.WriteLine("Unknown shape.");
            }
        }
    }
}
