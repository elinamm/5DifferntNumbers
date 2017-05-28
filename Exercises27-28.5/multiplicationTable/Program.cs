using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());

            if (n1 <= 10)
            {
                for (int i = n1; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", n, i,  i*n);
                }
            }
            else
                Console.WriteLine("{0} X {1} = {2}", n, n1, n1 * n);
        }
    }
}
