namespace DesignPatternsNET.Behavioral.Strategy;

public class Coordinate
{
    public double Long { get; set; }
    public double Lat { get; set; }

    public Coordinate(double l, double lat)
    {
        Long = l;
        Lat = lat;
    }
}