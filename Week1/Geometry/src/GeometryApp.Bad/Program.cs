using Geometry.Domain;
using GeometryApp.Bad.Services;

namespace GeometryApp.Bad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var userInterface = new ConsoleInterface(); // Simplified wrapper class for Console using IUserInterface
            var shapeFactory = new ShapeBuilder(userInterface); // Logic for the shape building

            /*
             * All of the below could be placed in a separate layer
             * So we could simply leave main for setting up and starting the main logic for the program.
            */

            userInterface.ShowMessage("Geometry calculator (Soon-To-Be-Refactored)");
            userInterface.ShowMessage("Shape (circle/rectangle): ");
            var input = userInterface.GetInput()?.Trim().ToLowerInvariant();

            // Has an issue of 
            IShape? shape = input switch
            {
                "circle" => shapeFactory.CreateCircle(),
                "retangle" => shapeFactory.CreateRectangle(),
                _ => null
            };

            if (shape is null)
            {
                userInterface.ShowMessage("Unknown shape.");
                return;
            }


            userInterface.ShowMessage($"Area: {shape.Area:F2}");
            userInterface.ShowMessage($"Perimeter: {shape.Perimeter:F2}");
        }
    }
}
