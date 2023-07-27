using Codecool.FlyThatDrone.Model;
using Codecool.FlyThatDrone.Service;

namespace Codecool.FlyThatDrone.UI;

public class FlyThatDroneUi
{
    private readonly IMovementEngine _movementEngine;

    public FlyThatDroneUi(IMovementEngine movementEngine)
    {
        _movementEngine = movementEngine;
    }

    public void Run()
    {
        var drone = new Drone(1, new Position(0, 0, 0));

        var movements = new[] { "forward", "backwards", "up", "somewhere" };
        Console.WriteLine($"Initial position for Drone #{drone.Id} {drone.Position}");

        foreach (var movement in movements)
        {
            if (_movementEngine.Move(drone, movement))
            {
                Console.WriteLine($"Successful {movement} movement ");
                Console.WriteLine($"New position for Drone #{drone.Id}: {drone.Position}");
            }
            else
            {
                Console.WriteLine($"Movement {movement} not possible ");
                Console.WriteLine($"Position unchanged for Drone #{drone.Id}: {drone.Position}");
            }
        }


        Console.ReadLine();
    }
}
