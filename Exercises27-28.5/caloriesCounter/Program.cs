using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Cheese – 500 calories
            //•	Tomato sauce – 150 calories
            //•	Salami – 600 calories
            //•	Pepper – 50 calories

            int n = int.Parse(Console.ReadLine());
            string ingredient = null;
            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        counter += 500;
                        break;
                    case "tomato sauce":
                        counter += 150;
                        break;
                    case "salami":
                        counter += 600;
                        break;
                    case "pepper":
                        counter += 50;
                        break;
                        
                }
            }
            Console.WriteLine("Total calories: {0}", counter);
        }
    }
}
