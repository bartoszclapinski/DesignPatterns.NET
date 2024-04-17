namespace DesignPatternsNET.Structural.Facade;

public static class FacadeApp
{
    public static void Run()
    {
        new ScanFacade().Scan("www.example.com");
    }
}