using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


//Exercise: Creating a Custom Generic Container(DataPacker<T>)
//Objective: Write a generic class in C# that acts as a fixed-size container for any data type. This will help you understand how generic classes encapsulate arrays and enforce type safety.

//Requirements:
//Class Definition: Create an internal generic class named DataPacker<T>.

//Internal Storage: *Declare a private array of type T with a fixed size of 3.

//Maintain an integer variable count (starting at 0) to keep track of how many elements have been added.

//Methods to Implement:

//Add(T item): A method that accepts an item of type T.

//If there is space left in the array, add the item to the next available index and increment count.

//If the array is already full, print a message to the console: "Array is full no space left".

//PrintAll(): A method that iterates through the array and prints only the elements that have been added so far, separated by tabs.


namespace ConsoleApp1
{
    internal class DataPacker<T>
    {
        T[] array = new T[3];
        int count = 0;
        public void Add(T item)
        {
            if (count < array.Length)
            {
                array[count] = item;
                count++;
            }
            else { Console.WriteLine("Array is full no space left"); }
        }
        public void PrintAll() 
        {
            Console.WriteLine("Array Elements are");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{array[i]} \t");
            }
        }
    }
}
