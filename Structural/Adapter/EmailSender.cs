namespace DesignPatternsNET.Structural.Adapter;

public class EmailSender : INotificationSender
{

    public void SendNotification(int userId, Notification notification) =>
        Console.WriteLine($"Sending email to user {userId}: {notification.Title} | {notification.Body}");
    
}