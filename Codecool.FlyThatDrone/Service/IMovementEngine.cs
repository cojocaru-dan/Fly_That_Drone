using Codecool.FlyThatDrone.Model;

namespace Codecool.FlyThatDrone.Service;

public interface IMovementEngine
{
    bool Move(Drone drone, string direction);
}

public class MovementEngine : IMovementEngine
{
    public bool Move(Drone drone, string direction)
    {
        return drone.Move(direction);
    }
}