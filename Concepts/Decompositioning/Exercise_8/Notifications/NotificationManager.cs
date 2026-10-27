namespace Decompositioning.Exercise_8.Notifications;

public class NotificationManager
{
    public int TotalNotificationsSent { get; private set; }
    
    public void ProcessNotification(Notification notification)
    {
        if (!notification.Validate())
            return;
        
        notification.Send();

        TotalNotificationsSent++;
        
        Console.WriteLine(
            $"Total notifications sent: {TotalNotificationsSent}");
    }
}