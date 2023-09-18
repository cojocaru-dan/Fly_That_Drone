using Codecool.FlyThatDrone.Service;
using Codecool.FlyThatDrone.UI;


IMovementEngine movementEngine = new MovementEngine();

FlyThatDroneUi ui = new FlyThatDroneUi(movementEngine);

ui.Run();
