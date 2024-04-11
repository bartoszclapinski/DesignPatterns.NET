namespace DesignPatternsNET.Behavioral.Mediator;

public class CheckBox : Component
{
    public void Select()
    {
        Console.WriteLine("CheckBox is selected");
        _mediator.Notify(this, "select");
    }
    
    public void SaveValue()
    {
        Console.WriteLine("CheckBox value is saved");
        _mediator.Notify(this, "save");
    }
}