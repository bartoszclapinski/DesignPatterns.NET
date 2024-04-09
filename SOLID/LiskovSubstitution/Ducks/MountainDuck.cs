namespace DesignPatternsNET.SOLID.LiskovSubstitution;

public class MountainDuck : Duck
{

    public override void Swim()
    {
        Console.WriteLine("MountainDuck swimming...");
    }

    public override void Quack()
    {
        Console.WriteLine("MountainDuck quacking...");
    }

    public override void Fly()
    {
        Console.WriteLine("MountainDuck flying...");
    }
}