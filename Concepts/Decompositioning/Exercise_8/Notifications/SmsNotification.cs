namespace Decompositioning.Exercise_8.Notifications;

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