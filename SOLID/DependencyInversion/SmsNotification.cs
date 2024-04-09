namespace DesignPatternsNET.SOLID.DependencyInversion;

public class SmsNotification : INotificationSender
{

    public void SendNotification(User user)
    {
        Console.WriteLine($"Sending notification to user: {user.Name} with phone number: {user.PhoneNumber}...");
    }
}