namespace DesignPatternsNET.Structural.Decorator;

public class SalamiPizzaDecorator : PizzaDecorator
{

    public SalamiPizzaDecorator(IPizza pizza) : base(pizza)
    {
    }
    
    public override double CalculatePrice()
    {
        return base.CalculatePrice() + 7;
    }
}