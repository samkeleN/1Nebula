public class Factory
{
    private RobotService _robotService;
    private PartsService _partsService;
    private CarService _carService;
    
    public Factory(RobotService robotService, PartsService partsService)
    {
        _robotService = new RobotService();
        _partsService = new PartsService();
        _carService = new CarService();
    }

    public Robot BuildRobot(Enum RobotType)
    {
        if(RobotType == RoboticDog)
            var parts = GetRobotPartsFor(RoboticDog);
            return _robotService.BuildRobotDog(parts);
        else if(RobotType == RoboticCat)
            var parts = GetRobotPartsFor(RoboticCat);
            return _robotService.BuildRobotCat(parts);
        else if(RobotType == RoboticDrone)
            var parts = GetRobotPartsFor(RoboticDrone);
            return _robotService.BuildRobotDrone(parts);
        else if (RobotType == RoboticCar)
            var parts = GetRobotPartsFor(RoboticCar);
            return _robotService.BuildRobotCar(parts);
        else
            return null;
    }

    public Car BuildCar(Enum CarType)
    {
        if(CarType == Toyota)
            var parts = GetCarPartsFor(Toyota);
            return _carService.BuildCar(parts);
        else if(RobotType == Ford)
            var parts = GetCarPartsFor(Ford);
            return _carService.BuildCar(parts);
        else if(RobotType == Opel)
            var parts = GetCarPartsFor(Opel);
            return _carService.BuildCar(parts);
        else if (RobotType == Honda)
            var parts = GetCarPartsFor(Honda);
            return _carService.BuildCar(parts);
        else
            return null;
    }

    public List<Parts> GetRobotPartsFor(Enum RobotType)
    {
        return _partsService.GetParts(RobotType);
    }

    public List<Parts> GetCarPartsFor(Enum CarType)
    {
        return _partsService.GetParts(CarType);
    }
}