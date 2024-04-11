namespace DesignPatternsNET.Creational.AbstractFactory.Interfaces;

public interface IUIElementFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}