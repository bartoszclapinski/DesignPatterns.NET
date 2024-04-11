using System.Net.Http.Headers;
using DesignPatternsNET.Creational.AbstractFactory.Interfaces;

namespace DesignPatternsNET.Creational.AbstractFactory.Windows;

public class WindowsFactory : IUIElementFactory
{

    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ITextBox CreateTextBox()
    {
        return new WindowsTexBox();
    }
}