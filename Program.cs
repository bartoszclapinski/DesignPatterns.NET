
using DesignPatternsNET.OOP;

var choose = 0;

while (choose != 9)
{
    Console.WriteLine("Choose an example:");
    Console.WriteLine("1. OOP");
    
    Console.WriteLine("9. Exit");
    choose = int.Parse(Console.ReadLine()!);

    switch (choose)
    {
        case 1:
            OopExamples.Run();
            break;
    }

}