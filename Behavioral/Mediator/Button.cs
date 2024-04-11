namespace DesignPatternsNET.Behavioral.Mediator;

public class Button : Component
{
    public void Render()
    {
        Console.WriteLine("Button is rendered");
    }
    
    public void Click()
    {
        Console.WriteLine("Button is clicked");
        _mediator.Notify(this, "click");
    }
}