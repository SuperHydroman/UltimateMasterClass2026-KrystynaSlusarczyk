namespace Decompositioning.Exercise_8.Notifications;

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