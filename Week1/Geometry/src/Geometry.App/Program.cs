using Geometry.Domain;

Console.WriteLine("Geometry calculator (refactored)");
Console.Write("Shape (circle/rectangle): ");
var shape = Console.ReadLine()?.Trim().ToLowerInvariant();

IShape? s = shape switch
{
    "circle" => BuildCircle(),
    "rectangle" => BuildRectangle(),
    _ => null
};

if (s is null)
{
    Console.WriteLine("Unknown shape.");
    return;
}

Console.WriteLine($"Area: {s.Area():F2}");
Console.WriteLine($"Perimeter: {s.Perimeter():F2}");

static IShape BuildCircle()
{
    Console.Write("Radius: ");
    var r = double.Parse(Console.ReadLine() ?? "0");
    return new Circle(r);
}

static IShape BuildRectangle()
{
    Console.Write("Width: ");
    var w = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Height: ");
    var h = double.Parse(Console.ReadLine() ?? "0");
    return new Rectangle(w, h);
}
