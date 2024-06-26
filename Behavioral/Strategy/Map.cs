﻿namespace DesignPatternsNET.Behavioral.Strategy;

public class Map
{
    private readonly IRouteStrategy _routeStrategy;

    public Map(IRouteStrategy routeStrategy)
    {
        _routeStrategy = routeStrategy;
    }
    
    public void CreateRoute(Coordinate start, Coordinate end)
    {
        _routeStrategy.CreateRoute(start, end);
    }
}