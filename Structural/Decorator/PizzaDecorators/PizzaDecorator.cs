namespace DesignPatternsNET.Structural.Decorator;

public abstract class PizzaDecorator : IPizza
{
    private readonly IPizza _pizza;

    protected PizzaDecorator(IPizza pizza)
    {
        _pizza = pizza;
    }

    public virtual double CalculatePrice()
    {
        return _pizza.CalculatePrice();
    }
    
}