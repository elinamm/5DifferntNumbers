using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    class Program
    {
        static void Main(string[] args)
        {

            //            •	First line: Month – May, June, July, August, September, October or December
            //•	Second line: Nights Count – an integer between[0... 200]

            string month = Console.ReadLine().ToLower();


            int nights = int.Parse(Console.ReadLine());

            double studio = 0;
            double doubleR = 0;
            double suite = 0;

            if (month == "may" || month == "october")
            {
                studio = 50 * nights;
                if (nights > 7)
                {

                    studio -= (studio * 0.05);
                }

                doubleR = 65 * nights;
                suite = 75 * nights;
            }
            else if (month == "june" || month == "september")
            {



                studio = 60 * nights;


                doubleR = 72 * nights;
                if (nights > 14)
                {
                    doubleR -= (doubleR * 0.1);
                }
                suite = 82 * nights;
            }


            else if (month == "july" || month == "august" || month == "december")
            {
                studio = 68 * nights;
                doubleR = 77 * nights;
                suite = 89 * nights;
                if (nights > 14)
                {
                    suite -= (suite * 0.15);
                }
            }

            if ((month == "september" || month == "october") && nights > 7)
            {
                studio -=(studio / nights);
            }


            Console.WriteLine("Studio: {0:F2} lv.\nDouble: {1:F2} lv.\nSuite: {2:F2} lv.",
                studio, doubleR, suite);




        }
    }
}
