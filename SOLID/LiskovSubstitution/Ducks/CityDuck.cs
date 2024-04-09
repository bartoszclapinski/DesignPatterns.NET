namespace DesignPatternsNET.SOLID.LiskovSubstitution;

public class CityDuck : Duck
{

    public override void Swim()
    {
        Console.WriteLine("CityDuck swimming...");
    }

    public override void Quack()
    {
        Console.WriteLine("CityDuck quacking...");
    }

    public override void Fly()
    {
        Console.WriteLine("CityDuck flying...");
    }
}