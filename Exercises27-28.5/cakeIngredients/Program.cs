using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {

            string ingredient = Console.ReadLine();


            int count = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine("Adding ingredient{0}.", ingredient);
                ingredient = Console.ReadLine();
                count++;
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", count);
        }
    }
}
