using System;  //we can use classes of System
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello   
{
    internal class Program
    {
           static void Main(string[] args)
        {
            //LOOPS IN C#:

            //While loops:
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //do-while:
            int j = 0;

            //will execute atleast once,even when the condition is false
            do
            {
                Console.WriteLine(j);
                j++;
            }  while (j > 5); //condition is false as j is equal to 0,but it will execute once and print 0.


            //for loop:

            for (int z = 0; z < 5; z++)
            {
                Console.WriteLine(z);

            }
            
            
                Console.ReadLine();
        }
    }
}
