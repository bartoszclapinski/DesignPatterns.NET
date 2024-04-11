namespace DesignPatternsNET.Behavioral.Mediator;

public static class MediatorApp
{
    public static void Run()
    {
        var check = new CheckBox();
        var button = new Button();
        new RegisterClientView(check, button);
        
        button.Click();
        check.Select();
    }
}