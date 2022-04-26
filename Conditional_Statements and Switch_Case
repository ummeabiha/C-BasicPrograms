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
            //Conditional Statements:
            Console.WriteLine("Enter your age ");
            string ageStr= Console.ReadLine();
            int age = Convert.ToInt32(ageStr);
            bool isBanned = true;
            
            if(age > 18)
            {
                Console.WriteLine("You Can Drive");
            }
            else if (age == 18)
            {
                Console.WriteLine("You can start driving now!");
            }
            else if (age<18 && isBanned)
            {
                Console.WriteLine("You cannot drive and You are banned");
            }
            else if (age < 18 || isBanned)
            {
                Console.WriteLine("Either You cannot drive or You are banned");
            }
            else
            {
                Console.WriteLine("You Cannot Drive");
            }

            //SWITCH_CASE:

            int agee = 78;
            switch (agee)
            {
                case 18:
                    Console.WriteLine("Please wait for an year");
                    break;
                case 20:
                    Console.WriteLine("You are 20");
                    break;
                default:
                    Console.WriteLine("You can Enjoy");
                    break;
            }
            
                        Console.ReadLine();
        }
    }
}
