namespace DesignPatternsNET.Structural.Decorator;

public static class DecoratorApp
{
    public static void Run()
    {
        var smallPizza = new SmallPizza();
        var smallPizzaWithCheese = new CheesePizzaDecorator(smallPizza);
        var smallPizzaWithCheeseAndHam = new HamPizzaDecorator(smallPizzaWithCheese);
        Console.WriteLine("Small pizza with cheese and ham costs: " + smallPizzaWithCheeseAndHam.CalculatePrice());
        
        var mediumPizza = new MediumPizza();
        var mediumPizzaWithCheese = new CheesePizzaDecorator(mediumPizza);
        var mediumPizzaWithCheeseAndHam = new HamPizzaDecorator(mediumPizzaWithCheese);
        var mediumPizzaWithCheeseAndHamAndSalami = new SalamiPizzaDecorator(mediumPizzaWithCheeseAndHam);
        Console.WriteLine("Medium pizza with cheese, ham and salami costs: " + mediumPizzaWithCheeseAndHamAndSalami.CalculatePrice());
        
        var largePizza = new LargePizza();
        var largePizzaWithCheese = new CheesePizzaDecorator(largePizza);
        Console.WriteLine("Large pizza with cheese costs: " + largePizzaWithCheese.CalculatePrice());
    }
}