using Geometry.Domain;
using GeometryApp.Bad.Interfaces;

namespace GeometryApp.Bad.Services;

public sealed class ShapeBuilder
{
    private readonly IUserInterface _UI;

    public ShapeBuilder(IUserInterface UI)
    {
        _UI = UI;
    }

    public IShape CreateCircle()
    {
        _UI.ShowMessage("Radius: ");
        var r = double.Parse(_UI.GetInput() ?? "0");

        return new Circle(radius: r);
    }

    public IShape CreateRectangle()
    {
        _UI.ShowMessage("Width: ");
        var w = double.Parse(_UI.GetInput() ?? "0");

        _UI.ShowMessage("Height: ");
        var h = double.Parse(_UI.GetInput() ?? "0");

        return new Rectangle(width: w, height: h);
    }
}
