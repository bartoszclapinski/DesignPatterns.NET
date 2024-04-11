namespace DesignPatternsNET.Behavioral.Observer;

public static class ObserverApp
{
    public static void Run()
    {
        var subscriber1 = new Subscriber("Subscriber 1");
        var subscriber2 = new Subscriber("Subscriber 2");
        var subscriber3 = new Subscriber("Subscriber 3");
        
        var publisher = new Publisher();
        publisher.Subscribe(subscriber1);
        publisher.Subscribe(subscriber2);
        publisher.Subscribe(subscriber3);
        
        publisher.Notify("Hello, subscribers!");
        
        publisher.Unsubscribe(subscriber2);
        
        publisher.Notify("Hello, subscribers again!");
    }
}