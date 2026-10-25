namespace Geometry.Domain;

public interface IShape
{
    double Area();
    double Perimeter();
}

public sealed class Circle(double radius) : IShape
{
    public double Radius { get; } = radius;
    public double Area() => Math.PI * Radius * Radius;
    public double Perimeter() => 2 * Math.PI * Radius;
}

public sealed class Rectangle(double width, double height) : IShape
{
    public double Width { get; } = width;
    public double Height { get; } = height;
    public double Area() => Width * Height;
    public double Perimeter() => 2 * (Width + Height);
}
