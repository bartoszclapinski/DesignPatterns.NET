namespace DesignPatternsNET.Behavioral.Strategy;

public class WalkStrategy : IRouteStrategy
{

    public void CreateRoute(Coordinate start, Coordinate end)
    {
        Console.WriteLine($"Walking from {start.Lat}, {start.Long} to {end.Lat}, {end.Long}");
    }
}