namespace DesignPatternsNET.Behavioral.Strategy;

public class BikeStrategy : IRouteStrategy
{

    public void CreateRoute(Coordinate start, Coordinate end)
    {
        Console.WriteLine($"Biking from {start.Lat}, {start.Long} to {end.Lat}, {end.Long}");
    }
}