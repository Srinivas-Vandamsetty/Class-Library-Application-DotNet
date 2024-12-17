using System;

namespace ClassLibraryProject.SolidPrinciples
{
    // Step 1: Create an abstraction
    public interface IMessageSender
    {
        void SendMessage(string message);
    }

    // Step 2: Implement the abstraction
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }

    // Step 3: High-level module depends on abstraction
    public class Notification
    {
        private readonly IMessageSender _messageSender;

        public Notification(IMessageSender messageSender)
        {
            _messageSender = messageSender ?? throw new ArgumentNullException(nameof(messageSender));
        }

        public void Notify(string message)
        {
            _messageSender.SendMessage(message);
        }
    }
}
