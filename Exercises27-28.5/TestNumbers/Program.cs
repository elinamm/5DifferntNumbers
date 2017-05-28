using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	First line – N – integer in the interval[1…100]
            //•	Second line – M – integer in the interval[1…100]
            //•	Third line – maximum sum boundary – integer in the interval[1…1000000]

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (sum >= boundary)
                    {
                        break;
                    }
                    sum += 3 * (i * j);
                    count++;
                }
            }
            Console.WriteLine("{0} combinations", count);
            if (sum >= boundary)
            {
                Console.WriteLine("Sum: {0} >= {1}", sum, boundary);
            }
            else
            {
                Console.WriteLine("Sum: {0}", sum);
            }

        }
    }
}
