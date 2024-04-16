namespace DesignPatternsNET.Structural.Adapter;

public class PushSender : INotificationSender
{

    public void SendNotification(int userId, Notification notification) =>
        Console.WriteLine($"Sending push notification to user {userId}: {notification.Title} | {notification.Body}");
    
}