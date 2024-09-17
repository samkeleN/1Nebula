public interface IRobotBuilder
{
    Robot BuildRobot(Enum robotType);
}

public interface ICarBuilder
{
    Car BuildCar(Enum carType);
}

public class RobotBuilder : IRobotBuilder
{
    private readonly RobotService _robotService;
    private readonly PartsService _partsService;

    public RobotBuilder(RobotService robotService, PartsService partsService)
    {
        _robotService = robotService;
        _partsService = partsService;
    }

    public Robot BuildRobot(Enum robotType)
    {
        var parts = GetRobotPartsFor(robotType);
        return robotType switch
        {
            RoboticDog => _robotService.BuildRobotDog(parts),
            RoboticCat => _robotService.BuildRobotCat(parts),
            RoboticDrone => _robotService.BuildRobotDrone(parts),
            RoboticCar => _robotService.BuildRobotCar(parts),
            _ => null,
        };
    }

    private List<Parts> GetRobotPartsFor(Enum robotType)
    {
        return _partsService.GetParts(robotType);
    }
}

public class CarBuilder : ICarBuilder
{
    private readonly CarService _carService;
    private readonly PartsService _partsService;

    public CarBuilder(CarService carService, PartsService partsService)
    {
        _carService = carService;
        _partsService = partsService;
    }

    public Car BuildCar(Enum carType)
    {
        var parts = GetCarPartsFor(carType);
        return carType switch
        {
            Toyota => _carService.BuildCar(parts),
            Ford => _carService.BuildCar(parts),
            Opel => _carService.BuildCar(parts),
            Honda => _carService.BuildCar(parts),
            _ => null,
        };
    }

    private List<Parts> GetCarPartsFor(Enum carType)
    {
        return _partsService.GetParts(carType);
    }
}

public class Factory
{
    private readonly IRobotBuilder _robotBuilder;
    private readonly ICarBuilder _carBuilder;

    public Factory(IRobotBuilder robotBuilder, ICarBuilder carBuilder)
    {
        _robotBuilder = robotBuilder;
        _carBuilder = carBuilder;
    }

    public Robot CreateRobot(Enum robotType)
    {
        return _robotBuilder.BuildRobot(robotType);
    }

    public Car CreateCar(Enum carType)
    {
        return _carBuilder.BuildCar(carType);
    }
}