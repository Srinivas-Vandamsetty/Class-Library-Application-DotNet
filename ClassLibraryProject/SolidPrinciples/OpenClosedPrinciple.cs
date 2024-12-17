using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProject.SolidPrinciples
{
    public abstract class PaymentMethod
    {
        public abstract void Pay(int amount);
    }

    // CreditCard payment method
    public class CreditCardPayment : PaymentMethod
    {
        public override void Pay(int amount)
        {
            Console.WriteLine($"Paid {amount}rs using Credit Card.");
        }
    }

    // Phonepe payment method
    public class PayPalPayment : PaymentMethod
    {
        public override void Pay(int amount)
        {
            Console.WriteLine($"Paid {amount}rs using PayPal.");
        }
    }

    // Cash payment method
    public class CashPayment : PaymentMethod
    {
        public override void Pay(int amount)

        {
            Console.WriteLine($"Paid {amount}rs in cash.");
        }
    }

}
