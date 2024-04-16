namespace DesignPatternsNET.Structural.Adapter;

public class SmsSender
{
    public void SendSms(string phoneNumber, string message) =>
        Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");
}