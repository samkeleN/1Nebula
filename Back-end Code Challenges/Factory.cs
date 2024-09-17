public class Factory
{
    private RobotService _robotService;
    private PartsService _partsService;
    private CarService _carService;

    public Factory(RobotService robotService, PartsService partsService, CarService carService)
    {
        _robotService = robotService;
        _partsService = partsService;
        _carService = carService;
    }

    public Robot BuildRobot(Enum RobotType)
    {
        List<Parts> parts = GetRobotPartsFor(RobotType);

        if (RobotType == RobotType.RoboticDog)
        {
            return _robotService.BuildRobotDog(parts);
        }
        else if (RobotType == RobotType.RoboticCat)
        {
            return _robotService.BuildRobotCat(parts);
        }
        else if (RobotType == RobotType.RoboticDrone)
        {
            return _robotService.BuildRobotDrone(parts);
        }
        else if (RobotType == RobotType.RoboticCar)
        {
            return _robotService.BuildRobotCar(parts);
        }
        else
        {
            return null;
        }
    }

    public Car BuildCar(Enum CarType)
    {
        List<Parts> parts = GetCarPartsFor(CarType);

        if (CarType == CarType.Toyota)
        {
            return _carService.BuildCar(parts);
        }
        else if (CarType == CarType.Ford)
        {
            return _carService.BuildCar(parts);
        }
        else if (CarType == CarType.Opel)
        {
            return _carService.BuildCar(parts);
        }
        else if (CarType == CarType.Honda)
        {
            return _carService.BuildCar(parts);
        }
        else
        {
            return null;
        }
    }

    private List<Parts> GetRobotPartsFor(Enum RobotType)
    {
        return _partsService.GetParts(RobotType);
    }

    private List<Parts> GetCarPartsFor(Enum CarType)
    {
        return _partsService.GetParts(CarType);
    }
}
