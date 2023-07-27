namespace Codecool.FlyThatDrone.Model;

public class Drone
{
    public int Id { get; }
    public Position Position { get; set; }

    public Drone(int id, Position position)
    {
        Id = id;
        Position = position;
    }
}
