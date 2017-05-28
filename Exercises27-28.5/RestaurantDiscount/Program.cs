using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {

            int group = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();

            double hallPrice = 0;
            string hall = null;
            double packagePrice = 0;
            double discount = 0;

            if (group <= 50)
            {
                hallPrice = 2500;
                hall = "Small Hall";
            }
            else if (group > 50 && group <= 100)
            {
                hallPrice = 5000;
                hall = "Terrace";
            }
            else if (group > 100 && group <= 120)
            {
                hallPrice = 7500;
                hall = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package == "normal")
            {
                packagePrice = 500;
                discount = (hallPrice + packagePrice) * 0.05;
            }
            else if (package == "gold")
            {
                packagePrice = 750;
                discount = (hallPrice + packagePrice) * 0.1;
            }
            else if (package == "platinum")
            {
                packagePrice = 1000;
                discount = (hallPrice + packagePrice) * 0.15;
            }

            double total = ((hallPrice + packagePrice) - discount) / group;
            Console.WriteLine("We can offer you the {0}\nThe price per person is {1:F2}$", hall, total);
        }
    }
}
