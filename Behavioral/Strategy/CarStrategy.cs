namespace DesignPatternsNET.Behavioral.Strategy;

public class CarStrategy : IRouteStrategy
{

    public void CreateRoute(Coordinate start, Coordinate end)
    {
        Console.WriteLine($"Driving from {start.Lat}, {start.Long} to {end.Lat}, {end.Long}");
    }
}