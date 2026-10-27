namespace Decompositioning;

public class Exercise_8 : Exercise
{
    protected override void Demonstrate()
    {
        var application = new NotificationManager();

        application.SendEmail(
            "gideon@example.com",
            "Your order has shipped!",
            true);

        application.SendSms(
            "+31612345678",
            "Your verification code is 123456",
            false);

        application.SendPush(
            "DEVICE-ABC123",
            "You have a new message!",
            2);
    }
}

public class NotificationManager
{
    private int _totalNotificationsSent;

    public void SendEmail(
        string email,
        string message,
        bool isHighPriority)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            Console.WriteLine("Invalid email address.");
            return;
        }

        if (string.IsNullOrWhiteSpace(message))
        {
            Console.WriteLine("Message cannot be empty.");
            return;
        }

        string priority = isHighPriority
            ? "HIGH"
            : "NORMAL";

        Console.WriteLine("Connecting to SMTP server...");
        Console.WriteLine($"Sending email to {email}");
        Console.WriteLine($"Priority: {priority}");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine("Email sent successfully.");

        _totalNotificationsSent++;
        Console.WriteLine(
            $"Total notifications sent: {_totalNotificationsSent}");
    }

    public void SendSms(
        string phoneNumber,
        string message,
        bool isInternational)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            Console.WriteLine("Invalid phone number.");
            return;
        }

        if (string.IsNullOrWhiteSpace(message))
        {
            Console.WriteLine("Message cannot be empty.");
            return;
        }

        if (message.Length > 160)
        {
            Console.WriteLine("SMS message exceeds 160 characters.");
            return;
        }

        string route = isInternational
            ? "International gateway"
            : "Local gateway";

        Console.WriteLine($"Connecting to {route}...");
        Console.WriteLine($"Sending SMS to {phoneNumber}");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine("SMS sent successfully.");

        _totalNotificationsSent++;
        Console.WriteLine(
            $"Total notifications sent: {_totalNotificationsSent}");
    }

    public void SendPush(
        string deviceToken,
        string message,
        int priorityLevel)
    {
        if (string.IsNullOrWhiteSpace(deviceToken))
        {
            Console.WriteLine("Invalid device token.");
            return;
        }

        if (string.IsNullOrWhiteSpace(message))
        {
            Console.WriteLine("Message cannot be empty.");
            return;
        }

        if (priorityLevel < 1 || priorityLevel > 3)
        {
            Console.WriteLine("Priority must be between 1 and 3.");
            return;
        }

        Console.WriteLine("Connecting to push notification service...");
        Console.WriteLine($"Sending push notification to {deviceToken}");
        Console.WriteLine($"Priority level: {priorityLevel}");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine("Push notification sent successfully.");

        _totalNotificationsSent++;
        Console.WriteLine(
            $"Total notifications sent: {_totalNotificationsSent}");
    }
}