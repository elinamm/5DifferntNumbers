using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theathre
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (day == "weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 12;
                    Console.WriteLine("{0}$", price);
                }
                else if (age > 18 && age <= 64)
                {
                    price = 18;
                    Console.WriteLine("{0}$", price);
                }
                else if (age > 64 && age <= 122)
                {
                    price = 12;
                    Console.WriteLine("{0}$", price);
                }
                else {
                    Console.WriteLine("Error!");
                }
            }
            else if (day == "weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 15;
                    Console.WriteLine("{0}$", price);
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                    Console.WriteLine("{0}$", price);
                }
                else if (age > 64 && age <= 122)
                {
                    price = 15;
                    Console.WriteLine("{0}$", price);
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (day == "holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                    Console.WriteLine("{0}$", price);
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                    Console.WriteLine("{0}$", price);
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                    Console.WriteLine("{0}$", price);
                }
                else
                {
                    Console.WriteLine("Error!");
                   
                }
            }
            else
                Console.WriteLine("Error!");
            
        }
    }
}
