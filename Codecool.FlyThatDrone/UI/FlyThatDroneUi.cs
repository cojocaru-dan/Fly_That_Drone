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
        List<Drone> drones = new List<Drone>
        { 
            new AirDrone(1, new Position(0, 0, 0)), 
            new BasicGroundDrone(2, new Position(1, 1, 1)),
            new DiagonalGroundDrone(3, new Position(2, 2, 2)),
        };

        var movements = new[] { "forward", "backwards", "up", "somewhere", "backward-right"};

        MoveDrones(drones, movements);
    }

    private void MoveDrones(List<Drone> drones, string[] movements)
    {
        foreach (Drone drone in drones)
        {
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
            Console.WriteLine("\n\n");
        }
        Console.ReadLine();
    }
}
