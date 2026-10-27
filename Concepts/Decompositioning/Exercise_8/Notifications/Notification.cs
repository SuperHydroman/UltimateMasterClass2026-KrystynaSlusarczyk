namespace Decompositioning.Exercise_8.Notifications;

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