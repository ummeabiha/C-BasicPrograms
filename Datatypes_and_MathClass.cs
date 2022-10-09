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
            int a = 34;
            float b = 34.4F; //for float we should mention capital F (otherwise will throw error)
            double c = 34.4D;  //wil compile without writing D also.
            bool isgreat = true;
            char d = 'a';  //should use single inverted commas for char
            string s = "This is a string";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(isgreat);
            Console.WriteLine(d);
            Console.WriteLine(s);



           //Math Class:    //present in class system
           Math.Max(34, 345);    //return the max value  
           Math.Min(34, 345);    //return the min value 
           double a =Math.Sqrt(36);      //sqrt returns double
           int b = Math.Abs(39);     //absolute value
           Math.Round(a);
           
           
            Console.ReadLine();
        }
    }
}
