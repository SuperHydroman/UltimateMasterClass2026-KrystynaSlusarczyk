namespace Decompositioning.Exercise_8.Notifications;

public class PushNotification : Notification
{
    private readonly string _deviceToken;
    private readonly int _priorityLevel;

    public PushNotification(string deviceToken, string message, int priorityLevel) : base(message)
    {
        _deviceToken = deviceToken;
        _priorityLevel = priorityLevel;
    }
    
    public override bool Validate()
    {
        if (string.IsNullOrWhiteSpace(_deviceToken))
        {
            Console.WriteLine("Invalid device token.");
            return false;
        }

        if (!ValidateMessage())
            return false;

        if (_priorityLevel is < 1 or > 3)
        {
            Console.WriteLine("Priority must be between 1 and 3.");
            return false;
        }

        return true;
    }

    public override void Send()
    {
        Console.WriteLine("Connecting to push notification service...");
        Console.WriteLine($"Sending push notification to {_deviceToken}");
        Console.WriteLine($"Priority level: {_priorityLevel}");
        Console.WriteLine($"Message: {Message}");
        Console.WriteLine("Push notification sent successfully.");
    }
}