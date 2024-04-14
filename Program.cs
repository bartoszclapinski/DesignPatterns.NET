using DesignPatternsNET.Behavioral.ChainOfResponsibility;
using DesignPatternsNET.Behavioral.Mediator;
using DesignPatternsNET.Behavioral.Observer;
using DesignPatternsNET.Behavioral.Strategy;
using DesignPatternsNET.Behavioral.TemplateMethod;
using DesignPatternsNET.OOP;
using DesignPatternsNET.Creational.Builder;
using DesignPatternsNET.Creational.Factory;
using DesignPatternsNET.Creational.AbstractFactory;
using DesignPatternsNET.Creational.Prototype;
using DesignPatternsNET.Creational.Singleton;

RunMainMenu();
return;

void RunMainMenu()
{
    var choose = 0;

    while (choose != 9)
    {
        Console.WriteLine("Choose an example:");
        Console.WriteLine("1. OOP");
        Console.WriteLine("2. Creational");
        Console.WriteLine("3. Behavioral");
        Console.WriteLine("9. Exit");
        choose = int.Parse(Console.ReadLine()!);
    
        switch (choose)
        {
            case 1:
                OopExamples.Run();
                break;
            case 2:
                RunCreationalMenu();
                break;
            case 3:
                RunBehavioralMenu();
                break;
        }

    }    
}

void RunBehavioralMenu()
{
    var behavioralChoose = 0;
    while (behavioralChoose != 9)
    {
        Console.WriteLine("Choose a behavioral example:");
        Console.WriteLine("1. Strategy");
        Console.WriteLine("2. Observer");
        Console.WriteLine("3. Mediator");
        Console.WriteLine("4. Chain of Responsibility");
        Console.WriteLine("5. Template Method");
        Console.WriteLine("9. Back");
        behavioralChoose = int.Parse(Console.ReadLine()!);
        
        switch (behavioralChoose)
        {
            case 1:
                StrategyApp.Run();
                break;
            case 2:
                ObserverApp.Run();
                break;
            case 3:
                MediatorApp.Run();
                break;
            case 4:
                ChainOfResponsibilityApp.Run();
                break;
            case 5:
                TemplateMethodApp.Run();
                break;
        }
    }
}

void RunCreationalMenu()
{
    var creationalChoose = 0;
    while (creationalChoose != 9)
    {
        Console.WriteLine("Choose a creational example:");
        Console.WriteLine("1. Builder");
        Console.WriteLine("2. Factory");
        Console.WriteLine("3. Abstract Factory");
        Console.WriteLine("4. Prototype");
        Console.WriteLine("5. Singleton");
        Console.WriteLine("9. Back");
        creationalChoose = int.Parse(Console.ReadLine()!);
        
        switch (creationalChoose)
        {
            case 1:
                InvoiceApp.Run();
                break;
            case 2:
                FactoryApp.Run();
                break;
            case 3:
                AbstractFactoryApp.Run();
                break;
            case 4:
                PrototypeApp.Run();
                break;
            case 5:
                SingletonApp.Run();
                break;
        }
    }
}