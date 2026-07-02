using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class get_set
    {
        int marks;


        public int Marks
        {
            get { return marks; }
            set
            {
                if (value >= 0)
                {
                    this.marks = value;
                    Console.WriteLine(marks);
                }
                else
                {
                    Console.WriteLine("Marks cannot be negative");
                }
            }
        }
            public get_set(int Marks)
        {
            this.Marks = Marks;
            
        }
        
        }
    }
