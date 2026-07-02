using System;
using System.Collections.Generic;
using System.Text;




//You are building a payment processing system for an e-commerce store.Every payment method needs a unique TransactionId, an Amount,
//and a way to execute the payment, but the processing logic differs completely between methods.


//        Your Task:

//Create an abstract class named PaymentProcessor.

//Add an automatic property for decimal Amount.

//Add a string property for TransactionId.

//Create an abstract method named ProcessPayment().

//Create a concrete class named CreditCardProcessor that inherits from PaymentProcessor.

//Implement ProcessPayment() to print: "Processing credit card payment of $[Amount]. Transaction ID: [TransactionId]"

//Create a concrete class named PayPalProcessor that inherits from PaymentProcessor.

//Implement ProcessPayment() to print: "Connecting to PayPal securely... Paid $[Amount]."

//Write a Main method that creates a List<PaymentProcessor>, adds one of each, and loops through them to call ProcessPayment().




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
