namespace DesignPatternsNET.Structural.Adapter;

public interface INotificationSender
{
    void SendNotification(int userId, Notification notification);
}