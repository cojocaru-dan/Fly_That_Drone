using Codecool.FlyThatDrone.Model;

namespace Codecool.FlyThatDroneTest;

public class MovementsTest
{
    private static readonly Position InitialPosition = new(0, 0, 0);

    private static object[] _movementCases =
    {
        new object[] { "forward", InitialPosition, InitialPosition with { X = InitialPosition.X + 1 } },
        new object[] { "backwards", InitialPosition, InitialPosition with { X = InitialPosition.X - 1 } },
        new object[] { "left", InitialPosition, InitialPosition with { X = InitialPosition.X - 1 } },
        new object[] { "right", InitialPosition, InitialPosition with { X = InitialPosition.X + 1 } },
    };
}
