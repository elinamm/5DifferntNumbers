using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n ; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
           
        }
    }
}
