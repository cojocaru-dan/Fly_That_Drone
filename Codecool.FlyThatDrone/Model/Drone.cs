
namespace Codecool.FlyThatDrone.Model;

public abstract class Drone
{
    public int Id { get; }
    public Position Position { get; set; }

    public Drone(int id, Position position)
    {
        Id = id;
        Position = position;
    }

    public abstract bool Move(string direction);
}

public class BasicGroundDrone : Drone
{
    public BasicGroundDrone(int id, Position position) : base(id, position) { }

    public override bool Move(string direction)
    {
        switch (direction.ToLower())
        {
            case "forward":
                Position = new Position(Position.X, Position.Y + 1, Position.Z);
                break;
            case "backward":
                Position = new Position(Position.X, Position.Y - 1, Position.Z);
                break;
            case "left":
                Position = new Position(Position.X - 1, Position.Y, Position.Z);
                break;
            case "right":
                Position = new Position(Position.X + 1, Position.Y, Position.Z);
                break;
            default:
                Console.WriteLine($"This is BasicGroundDrone and it can't move in {direction} direction.");
                return false;
        }
        return true;
    }
}

public class DiagonalGroundDrone : Drone
{
    public DiagonalGroundDrone(int id, Position position) : base(id, position) { }

    public override bool Move(string direction)
    {
        switch (direction.ToLower())
        {
            case "forward-left":
                Position = new Position(Position.X - 1, Position.Y + 1, Position.Z);
                break;
            case "forward-right":
                Position = new Position(Position.X + 1, Position.Y + 1, Position.Z);
                break;
            case "backward-left":
                Position = new Position(Position.X - 1, Position.Y - 1, Position.Z);
                break;
            case "backward-right":
                Position = new Position(Position.X + 1, Position.Y - 1, Position.Z);
                break;
            default:
                Console.WriteLine($"This is DiagonalGroundDrone and it can't move in {direction} direction.");
                return false;
        }
        return true;
    }
}

public class AirDrone : Drone
{
    public AirDrone(int id, Position position) : base(id, position) { }

    public override bool Move(string direction)
    {
        switch (direction.ToLower())
        {
            case "up":
                Position = new Position(Position.X, Position.Y, Position.Z + 1);
                break;
            case "down":
                Position = new Position(Position.X, Position.Y, Position.Z - 1);
                break;
            default:
                Console.WriteLine($"This is AirDrone and it can't move in {direction} direction.");
                return false;
        }
        return true;
    }
}
