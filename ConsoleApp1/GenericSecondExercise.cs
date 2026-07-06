using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;



//Coding Assignment: The Generic History Tracker (HistoryLog<T>)
//Objective:
//Write an internal generic class named HistoryLog<T> that stores a history of recent operations, logs, or user inputs of any data type. It will feature a fixed capacity, a way to add items, and a generic method to search for a specific item.

//Requirements:
//Class Definition &Fields:

//Create an internal class HistoryLog<T>.

//Inside, declare a private array of type T with a fixed size of 5.

//Maintain a private integer head(or count) initialized to 0 to keep track of the current number of logged items.

//Methods to Implement:

//public void Log(T entry): Adds a new entry to the history log.

//If there is room in the array, store the entry and increment your count.

//If the log is full (reached 5 items), print: "Log capacity reached. Cannot log more items."

//public void ShowHistory(): Iterates through the array and prints all logged entries in order, each on a new line.

//public bool ContainsItem(T target): A method that searches the log for a specific item.

//Use .Equals() to compare each stored item with target.

//Return true if found, and false otherwise.




namespace ConsoleApp1
{
    internal class HistoryLog<T>

    {
        T[] array = new T[5];
        private int count = 0;


        public void Log(T entry)

        {
            if (count < 5)
            {
                array[count] = entry;
                count++;
            }
            else
            {
                Console.WriteLine("Log capacity reached. Cannot log more items.");
            }
         }

        public void ShowHistory()
        {
                Console.Write($"Elements = \t");
            for (int i = 0; i < count; i++)
            {
                Console.Write( $"{array[i]}\t" );
            }
        }

        public bool Containsitem(T target)
        {
            for (int i = 0; i < count; i++) 
            { 

                if (array[i].Equals(target))
                {
                    return true;
                   
                }
               
            }
            return false;
        }
    }
}
