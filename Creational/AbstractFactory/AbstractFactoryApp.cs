namespace DesignPatternsNET.Creational.AbstractFactory;

public static class AbstractFactoryApp
{
    public static void Run()
    {
        var macFactory = new Mac.MacFactory();
        var windowsFactory = new Windows.WindowsFactory();

        var mac = new CreateUserInterface(macFactory);
        mac.RenderUserInterface();

        var windows = new CreateUserInterface(windowsFactory);
        windows.RenderUserInterface();
    }
}