using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class op_overloading
    {
        public string name;
        public int age;

       

        public static op_overloading operator +(op_overloading obj1, op_overloading obj2)

        {

            op_overloading obj3 = new op_overloading();

                obj3.name = obj1.name + obj2.name;
                obj3.age = obj1.age+ obj2.age;
            return obj3;
        }



            

        


    }
}
