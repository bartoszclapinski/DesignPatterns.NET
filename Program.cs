using DesignPatternsNET.OOP;
using DesignPatternsNET.Creational.Builder;
using DesignPatternsNET.Creational.Factory;
using DesignPatternsNET.Creational.AbstractFactory;

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
        }
    }
}