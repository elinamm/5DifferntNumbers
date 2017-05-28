using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            // a ≤ n1 < n2 < n3 < n4 ≤ n5 ≤ b

            if (b - a >= 5)
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = a; j <= b; j++)
                    {
                        for (int k = a; k <= b; k++)
                        {
                            for (int m = a; m <= b; m++)
                            {
                                for (int n = a; n <= b; n++)
                                {
                                    if (i >= a && i < j  && j < k &&  k < m && m > k && 
                                        m < n && n > m && n <= b)
                                    {
                                        Console.WriteLine("{0} {1} {2} {3} {4} ", i, j, k, m, n);
                                    }

                                }

                            }
                        }
                    }

                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
