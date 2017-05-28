using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (System.FormatException)
            {

                Console.WriteLine("Invalid input!");
            }
        }
    }
}
