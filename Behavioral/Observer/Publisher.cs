namespace DesignPatternsNET.Behavioral.Observer;

public class Publisher
{
    private readonly List<ISubscriber> _subscribers = new ();
    
    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }
    
    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }
    
    public void Notify(string message)
    {
        foreach (ISubscriber subscriber in _subscribers)
        {
            subscriber.Update(message);
        }
    }
}