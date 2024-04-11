namespace DesignPatternsNET.Behavioral.Strategy;

public interface IRouteStrategy
{
    void CreateRoute(Coordinate start, Coordinate end);
}