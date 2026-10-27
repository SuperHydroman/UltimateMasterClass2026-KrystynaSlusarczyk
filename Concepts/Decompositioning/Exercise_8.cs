namespace Decompositioning;

public class Exercise_8 : Exercise
{
    protected override void Demonstrate()
    {
        var application = new NotificationManager();

        application.ProcessNotification(
            new EmailNotification(
                "gideon@example.com", 
                "Your order has shipped!", 
                true
            )
        );

        Console.WriteLine("--------------------");

        application.ProcessNotification(
            new SmsNotification(
                "+31612345678",
                "Your verification code is 123456",
                false
            )
        );
        
        Console.WriteLine("--------------------");
        
        application.ProcessNotification(
            new PushNotification(
            "DEVICE-ABC123",
            "You have a new message!",
            2
            )
        );
    }
}

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

public class EmailNotification : Notification
{
    private readonly string _email;
    private readonly string _priority;

    public EmailNotification(string email, string message, bool isHighPriority) : base(message)
    {
        _email = email;
        _priority = isHighPriority ? "HIGH" : "NORMAL";
    }

    public override bool Validate()
    {
        if (string.IsNullOrWhiteSpace(_email))
        {
            Console.WriteLine("Invalid email address.");
            return false;
        }
        
        return ValidateMessage();
    }

    public override void Send()
    {
        Console.WriteLine("Connecting to SMTP server...");
        Console.WriteLine($"Sending email to {_email}");
        Console.WriteLine($"Priority: {_priority}");
        Console.WriteLine($"Message: {Message}");
        Console.WriteLine("Email sent successfully.");
    }
}

public class SmsNotification : Notification
{
    private readonly string _phoneNumber;
    private readonly string _route;

    public SmsNotification(string phoneNumber, string message, bool isInternational) : base(message)
    {
        _phoneNumber = phoneNumber;
        _route = isInternational ? "International gateway" : "Local gateway";
    }

    public override bool Validate()
    {
        if (string.IsNullOrWhiteSpace(_phoneNumber))
        {
            Console.WriteLine("Invalid phone number.");
            return false;
        }

        if (!ValidateMessage())
            return false;

        if (Message.Length > 160)
        {
            Console.WriteLine("SMS message exceeds 160 characters.");
            return false;
        }

        return true;
    }

    public override void Send()
    {
        Console.WriteLine($"Connecting to {_route}...");
        Console.WriteLine($"Sending SMS to {_phoneNumber}");
        Console.WriteLine($"Message: {Message}");
        Console.WriteLine("SMS sent successfully.");
    }
}

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

public abstract class Notification
{
    protected readonly string Message;

    protected Notification(string message)
    {
        Message = message;
    }

    protected bool ValidateMessage()
    {
        if (string.IsNullOrWhiteSpace(Message))
        {
            Console.WriteLine("Message cannot be empty.");
            return false;
        }

        return true;
    }
    
    public abstract bool Validate();
    public abstract void Send();
}