namespace DesignPatternsNET.OOP.AbstractClasses;

public class EmailSender
{
    private void ConnectToSmtpServer()
    {
        Console.WriteLine("Connecting to SMTP server...");
    }
    
    private void InsertCredentials()
    {
        Console.WriteLine("Inserting credentials...");
    }

    public void SendEmail(string to, string title, string body)
    {
        ConnectToSmtpServer();
        InsertCredentials();
        Console.WriteLine($"Sending email to {to} with title {title} and body {body}...");
        DisconnectFromSmtpServer();
    }
    
    private void DisconnectFromSmtpServer()
    {
        Console.WriteLine("Disconnecting from SMTP server...");
    }
}