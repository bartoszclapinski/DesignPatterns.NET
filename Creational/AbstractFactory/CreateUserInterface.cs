using DesignPatternsNET.Creational.AbstractFactory.Interfaces;

namespace DesignPatternsNET.Creational.AbstractFactory;

public class CreateUserInterface
{
    private readonly IUIElementFactory _factory;

    public CreateUserInterface(IUIElementFactory factory)
    {
        _factory = factory;
    }
    
    public void RenderUserInterface()
    {
        var button = _factory.CreateButton();
        var textBox = _factory.CreateTextBox();
        
        button.Render();
        textBox.Render();
    }
}