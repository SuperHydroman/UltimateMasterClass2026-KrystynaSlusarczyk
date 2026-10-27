using Decompositioning.Exercise_8.Notifications;

namespace Decompositioning.Exercise_8;

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