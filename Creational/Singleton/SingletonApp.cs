namespace DesignPatternsNET.Creational.Singleton;

public static class SingletonApp
{
    public static void Run()
    {
        var configuration1 = Configuration.Instance();
        configuration1.StringProperty = "Hello";
        configuration1.IntProperty = 42;
        Console.WriteLine($"String property for configuration1: {configuration1.StringProperty}");
        Console.WriteLine($"Int property for configuration1: {configuration1.IntProperty}");
        
        var configuration2 = Configuration.Instance();
        
        Console.WriteLine($"Reference equality: {ReferenceEquals(configuration1, configuration2)}");
        Console.WriteLine(ReferenceEquals(configuration1, configuration2) ? "Singleton works" : "Singleton failed");
        Console.WriteLine($"String property for configuration2: {configuration2.StringProperty}");
        Console.WriteLine($"Int property for configuration2: {configuration2.IntProperty}");
    }
}