using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddNumber
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());

            while (n % 2 == 0) 
            {
                Console.WriteLine("Please write an odd number.");
                n = int.Parse(Console.ReadLine());               

            } 

            Console.WriteLine("The number is: {0}", Math.Abs(n));




        }

    }
}
