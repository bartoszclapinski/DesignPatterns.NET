namespace DesignPatternsNET.OOP.Classes;

public class Person
{
    public Person(string firstName)
    {
        FirstName = firstName;
    }

    public string FirstName { get; set; }
    
    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {FirstName}");
    }
}