using DesignPatternsNET.SOLID.DependencyInversion;

namespace DesignPatternsNET.SOLID;

public class AuthenticationManager
{
    private INotificationSender _notificationSender;
    
    public AuthenticationManager(INotificationSender notificationSender)
    {
        _notificationSender = notificationSender;
    }
    
    public void Authenticate(User user, string emial, string password)
    {
        if (user.Email == emial && user.Password == password)
        {
            _notificationSender.SendNotification(user);
            Console.WriteLine("Notification sent successfully!");
        }
        else
        {
            Console.WriteLine("User not authenticated");
        }
    }
}