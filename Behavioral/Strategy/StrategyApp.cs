namespace DesignPatternsNET.Behavioral.Strategy;

public static class StrategyApp
{
    public static void Run()
    {
        var start = new Coordinate(0, 0);
        var end = new Coordinate(1, 1);
        
        var bikeStrategy = new BikeStrategy();
        var carStrategy = new CarStrategy();
        var walkingStrategy = new WalkStrategy();
        
        var mapBike = new Map(bikeStrategy);
        var mapCar = new Map(carStrategy);
        var mapWalking = new Map(walkingStrategy);
        
        mapBike.CreateRoute(start, end);
        mapCar.CreateRoute(start, end);
        mapWalking.CreateRoute(start, end);
    }
}