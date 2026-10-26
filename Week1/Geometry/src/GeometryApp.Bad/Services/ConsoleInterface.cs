using GeometryApp.Bad.Interfaces;

namespace GeometryApp.Bad.Services;

public class ConsoleInterface : IUserInterface
{
    public string? GetInput()
    => Console.ReadLine();

    public void ShowMessage(string? value)
        => Console.WriteLine(value);
}
