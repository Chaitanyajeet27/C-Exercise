using System;
using System.Collections.Generic;
using System.Text;

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
