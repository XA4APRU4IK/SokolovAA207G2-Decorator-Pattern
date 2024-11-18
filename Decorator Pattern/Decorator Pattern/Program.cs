using System;
using System.Collections.Generic;
using Decorator_pattern;

public interface INotifier
{
    void Send(string message);
}
public class Program
{
    public static void Main(string[] args)
    {
        var admins = new List<string> { "admin1@example.com", "admin2@example.com" };
        INotifier notifier = new EmailNotifier(admins);
        var phoneNumbers = new List<string> { "1234567890", "0987654321" };
        notifier = new SmsNotifier(notifier, phoneNumbers);
        var facebookUsers = new List<string> { "user1", "user2" };
        notifier = new TelegramNotifier(notifier, facebookUsers);
        notifier.Send("Важное сообщение!");
    }
}
