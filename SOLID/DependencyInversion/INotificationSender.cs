namespace DesignPatternsNET.SOLID.DependencyInversion;

public interface INotificationSender
{
    void SendNotification(User user);
}