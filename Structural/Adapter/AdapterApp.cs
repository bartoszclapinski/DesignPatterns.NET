namespace DesignPatternsNET.Structural.Adapter;

public static class AdapterApp
{
    public static void Run()
    {
        INotificationSender emailSender = new EmailSender();
        emailSender.SendNotification(1, new Notification {Body = "Email test body", Title = "Test title"});
        
        INotificationSender pushSender = new PushSender();
        pushSender.SendNotification(2, new Notification {Body = "Push test body", Title = "Test title"});
        
        INotificationSender smsSenderAdapter = new SmsSenderAdapter();
        smsSenderAdapter.SendNotification(3, new Notification {Body = "Sms test body", Title = "Test title"});
    }
}