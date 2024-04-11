using DesignPatternsNET.Creational.AbstractFactory.Interfaces;

namespace DesignPatternsNET.Creational.AbstractFactory.Mac;

public class MacFactory : IUIElementFactory
{

    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ITextBox CreateTextBox()
    {
        return new MacTextBox();
    }
}