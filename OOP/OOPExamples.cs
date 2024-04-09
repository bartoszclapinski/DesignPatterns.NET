using DesignPatternsNET.OOP.AbstractClasses;
using DesignPatternsNET.OOP.Classes;
using DesignPatternsNET.OOP.Encapsulation;
using DesignPatternsNET.OOP.Inheritance;
using DesignPatternsNET.OOP.Interfaces;
using DesignPatternsNET.OOP.Polymorphism;

namespace DesignPatternsNET.OOP;

public static class OopExamples
{
    public static void Run()
    {
        //  Classes
        var person = new Person("John");
        Console.WriteLine(person.FirstName);
        person.SayHello();
        person.FirstName = "Jane";
        person.SayHello();

        //  Interfaces
        static IPrinter GetPrinter()
        {
            return new Hp();
        }

        IPrinter printer = GetPrinter();
        printer.Print("Message for printer");

        //  Encapsulation
        var bankAccount = new BankAccount("John Smith");
        bankAccount.Deposit(1000);
        bankAccount.Withdraw(300);
        Console.WriteLine(bankAccount.GetBalance());

        //  Inheritance
        var personalBankAccount = new PersonalBankAccount();
        personalBankAccount.Deposit(1000);
        Console.WriteLine(personalBankAccount.GetBalance());
    
        var companyBankAccount = new CompanyBankAccount();
        companyBankAccount.Deposit(1000);
        Console.WriteLine(companyBankAccount.GetBalance());
    
        //  Polymorphism
        var polyBankAccount = new PolyBankAccount();
        polyBankAccount.Deposit(1000);
        Console.WriteLine(polyBankAccount.GetBalance());
        // polyBankAccount.Withdraw(1300); - throws an exception
    
        var polyCompanyBankAccount = new PolyCompanyBankAccount();
        polyCompanyBankAccount.Deposit(1000);
        Console.WriteLine(polyCompanyBankAccount.GetBalance());
        polyCompanyBankAccount.Withdraw(1300); // no exception
        Console.WriteLine(polyCompanyBankAccount.GetBalance());
        
        //  Abstraction
        EmailSender emailSender = new EmailSender();
        //emailSender.ConnectToSmtpServer();
        //emailSender.InsertCredentials();
        emailSender.SendEmail("Jane", "Hello", "Hello, Jane!");
        //emailSender.DisconnectFromSmtpServer();
    }
}