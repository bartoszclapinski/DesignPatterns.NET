namespace DesignPatternsNET.SOLID.LiskovSubstitution;

public class RubberDuck : Duck
{

    public override void Swim()
    {
        Console.WriteLine("RubberDuck swimming...");
    }

    public override void Quack()
    {
        Console.WriteLine("RubberDuck quacking...");
    }
    
    public override void Fly()
    {
        throw new NotImplementedException("RubberDuck cannot fly!");
    }
}