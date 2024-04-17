namespace DesignPatternsNET.Structural.Decorator;

public class SmallPizza : IPizza
{

    public double CalculatePrice()
    {
        return 15;
    }
}