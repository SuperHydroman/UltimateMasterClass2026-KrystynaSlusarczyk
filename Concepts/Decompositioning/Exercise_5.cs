namespace Decompositioning;

public class Exercise_5 : Exercise
{
    protected override void Demonstrate()
    {
        NotificationService.SendEmail("g.vandenherik@gmsnl.com", "Hello world to E-mail Server");
        Console.WriteLine("-------------------");
        NotificationService.SendSms("g.vandenherik@gmsnl.com", "Hello world to SMS Gateway");
    }
}


public static class NotificationService
{
    public static void SendEmail(string recipient, string message)
        => SendMessage(recipient, message, "Connecting to email server...");

    public static void SendSms(string recipient, string message)
        => SendMessage(recipient, message, "Connecting to SMS gateway...");
    
    private static void SendMessage(string recipient, string message, string connectionMessage)
    {
        if (!IsValidRecipient(recipient) || !IsValidMessage(message))
            return;
        
        Console.WriteLine(connectionMessage);
        Console.WriteLine($"Sending to {recipient}: {message}");
        Console.WriteLine("Notification sent");
    }
    
    private static bool IsValidRecipient(string recipient)
    {
        if (string.IsNullOrWhiteSpace(recipient))
        {
            Console.WriteLine("Invalid recipient");
            return false;
        }
        
        return true;
    }

    private static bool IsValidMessage(string message)
    {
        if (string.IsNullOrWhiteSpace(message))
        {
            Console.WriteLine("Invalid message");
            return false;
        }
        
        return true;
    }
}