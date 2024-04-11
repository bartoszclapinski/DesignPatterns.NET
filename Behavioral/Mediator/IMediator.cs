namespace DesignPatternsNET.Behavioral.Mediator;

public interface IMediator
{
    void Notify(Component sender, string @event);
}