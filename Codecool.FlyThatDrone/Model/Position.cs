namespace Codecool.FlyThatDrone.Model;

public record Position(int X, int Y, int Z)
{
    public override string ToString()
    {
        return $"[{nameof(X)}: {X}, {nameof(Y)}: {Y}, {nameof(Z)}: {Z}]";
    }
}
