namespace DesignPatternsNET.Behavioral.Observer;

public class Subscriber : ISubscriber
{
    public Subscriber(string name)
    {
        Name = name;
    }

    private string Name { get; set; }
    
    public void Update(string message)
    {
        Console.WriteLine($"{Name} received message: {message}");
    }
}