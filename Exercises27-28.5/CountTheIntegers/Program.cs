using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            int num = 0;
            while (int.TryParse (input, out num))
            {
                input = Console.ReadLine();
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
