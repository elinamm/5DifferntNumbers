using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = 0;

            switch (profession)
            {
                default:

                    price = 1.20;
                    break;
                case "Athlete":

                    price = 0.7;
                    break;
                case "Businessman":

                    price = 1;
                    break;
                case "Businesswoman":

                    price = 1;
                    break;
                case "SoftUni Student":

                    price = 1.7;
                    break;
            }
            Console.WriteLine("The {0} has to pay {1:F2}.", profession, price * quantity);
        }
    }
}
