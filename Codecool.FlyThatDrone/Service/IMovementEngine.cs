using Codecool.FlyThatDrone.Model;

namespace Codecool.FlyThatDrone.Service;

public interface IMovementEngine
{
    bool Move(Drone drone, string direction);
}
