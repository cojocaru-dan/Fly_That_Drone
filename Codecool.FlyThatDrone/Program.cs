using Codecool.FlyThatDrone.Service;
using Codecool.FlyThatDrone.UI;


IMovementEngine movementEngine = null;

FlyThatDroneUi ui = new FlyThatDroneUi(movementEngine);

ui.Run();
