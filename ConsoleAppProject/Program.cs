using System;
using System.Reflection;
using ClassLibraryProject.SolidPrinciples;

class Program
{
    public static void Main()

    {
        // Single Responsibility Priniciple.
        Console.WriteLine("\n***** Single Responsibility Priniciple *****");

        User user = new User { Name = "Sai Srinivas", Email = "sai.srinivas@gmail.com" };

        UserRepository userRepository = new UserRepository();
        userRepository.Save(user);

        EmailService emailService = new EmailService();
        emailService.SendEmail(user, "Welcome to our service!");


        // Open Closed Priniciple.
        Console.WriteLine("\n***** Open Closed Priniciple *****");

        // Create an object of CreditCardPayment
        PaymentMethod paymentMethod = new CreditCardPayment();
        paymentMethod.Pay(2000);

        // Create an object of PayPalPayment
        paymentMethod = new PayPalPayment();
        paymentMethod.Pay(3000);

        // Create an object of CashPayment
        paymentMethod = new CashPayment();
        paymentMethod.Pay(12000);


        // Liskov Substitution Priniciple.
        Console.WriteLine("\n***** Liskov Substitution Priniciple *****");

        // Using base class reference but subclass objects
        Animal animal1 = new Dog();
        Animal animal2 = new Cat();

        animal1.MakeSound(); // Dog barks
        animal2.MakeSound(); // Cat meows


        // Interface Segregation Principle.
        Console.WriteLine("\n***** Interface Segregation Principle *****");

        // Basic printer only prints
        IPrinter basicPrinter = new BasicPrinter();
        basicPrinter.Print("Document 1");

        // Advanced printer can print, scan, and fax
        AdvancedPrinter advancedPrinter = new AdvancedPrinter();
        advancedPrinter.Print("Document 2");
        advancedPrinter.Scan("Document 3");
        advancedPrinter.Fax("Document 4");

        // Dependency Inversion Principle.
        Console.WriteLine("\n***** Dependency Inversion Principle *****");

        // Inject EmailSender (low-level module) into Notification (high-level module)
        IMessageSender emailSender = new EmailSender();
        Notification emailNotification = new Notification(emailSender);
        emailNotification.Notify("Hello via Email!");

        // Inject SmsSender (low-level module) into Notification (high-level module)
        IMessageSender smsSender = new SmsSender();
        Notification smsNotification = new Notification(smsSender);
        smsNotification.Notify("Hello via SMS!");
    }

}
