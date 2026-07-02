using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Generic
    {
      public void add<V>(V [] input )
        {
          Console.WriteLine(typeof(V));
             for (int i = 0; i < input.Length; i++) {
                Console.WriteLine( input[i] );
            }
            

        }
    }
}
