using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class InheritanceExercise
    {
        public abstract class PaymentProcessor
        {
            public decimal Amount { get; set; }
            public string? TransactionId { get; set; }

            public abstract void ProccessPayment();
        }

        public class CreditCardProcessor : PaymentProcessor
        {

            public override void ProccessPayment()
            {
                Console.WriteLine($"Processing credit card payment of ${Amount}. Transaction ID: {TransactionId}");
            }

        }
        public class PaypalProccessor : PaymentProcessor
        {

            public override void ProccessPayment()
            {
                Console.WriteLine($"Connecting to PayPal securely... Paid ${Amount}.");
            }

        }
    }
}
