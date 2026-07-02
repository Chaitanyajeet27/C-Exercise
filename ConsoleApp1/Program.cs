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
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ConsoleApp1
{

   

    internal class Program
    {
        public static void Main(string[] args)
        {
            ////var Gen = new get_set(10);
            //DataPacker<int> data = new DataPacker<int>();

            //data.Add(23);
            //data.Add(92);
            //data.Add(12);
            //data.Add(12);

            //data.PrintAll();

            
            ////int [] Number = new int[4];
            //int [] Number = {1,2,3,4,5};
            //String[] Name = { "Chaitanya","Abhinav", "Dhruv" };
            //var display = new Generic();

            //display.add(Name);
            


            //List<PaymentProcessor> paymentList = new List<PaymentProcessor>();
            //CreditCardProcessor credit = new()
            //{

            //    Amount = 59.6m,
            //    TransactionId = "CREDIT-3213"
            //};

            //PaypalProccessor paypal = new()
            //{
            //    Amount = 45.9m,
            //    TransactionId = "GFSCV-213"
            //};

            //Console.WriteLine("--- Starting Payment Processing ---");

            //foreach (PaymentProcessor processor in paymentList)
            //{
            //   processor.ProccessPayment();

            //}

            //DateTime np = DateTime.Now;
            //Console.WriteLine($"{np:d}");

            //int a = 20, b = 15;
            //Console.WriteLine(a == b);
            Console.ReadKey();

        }
    }
}

