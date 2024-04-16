namespace DesignPatternsNET.Structural.Adapter;

public class SmsSenderAdapter : INotificationSender
{
    private SmsSender _smsSender = new SmsSender();
    
    public void SendNotification(int userId, Notification notification)
    {
        _smsSender.SendSms(userId.ToString(), $"{notification.Title} | {notification.Body}");
    }
}