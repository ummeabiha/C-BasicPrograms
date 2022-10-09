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
                    //STRINGS:
            string hello = "Hello, This is \"Abiha\"";
            Console.WriteLine(hello.Length);  //returns length of the string
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello.ToUpper());
            
            //String Concatenation:
            Console.WriteLine(hello + " you are nice");
            Console.WriteLine(string.Concat(hello + " you are nice"));

            //String Interpulation
            Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter no of candies");
            string candies=Console.ReadLine();
            
            Console.WriteLine($"Your name is {name}. You will get {candies} candies");

            //String Indexing:
            string day="Today is a sunny day";
            Console.WriteLine(day[0]);   //print T
            Console.WriteLine(day.IndexOf("day"));
            //return a new line will not affect hello
            Console.WriteLine(day.Substring(1)); //will start from the given index and print the whole line.
            
            
                        //string concatenation
            Console.WriteLine("You will get 4 more candies " + candies + 4); //output--> 44
            Console.WriteLine("You will get 4 more candies " + Convert.ToInt32(candies) + 4); //output--> 44

            //should place brackets at typecasting part, so it will execute first!!
            Console.WriteLine("You will get 4 more candies " + (Convert.ToInt32(candies)+4)); 
            
             Console.ReadLine();
        }
    }
}

            
            
            
