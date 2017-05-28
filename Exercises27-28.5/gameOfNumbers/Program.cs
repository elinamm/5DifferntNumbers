using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //•	First line – N – integer in the interval[1…999]
            //•	Second line – M – integer in the interval[N…1000]
            //•	Third line – magical number – integer in the interval[1…10000]

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int left = 0;
            int right = 0;
            bool magic = false;
            int count = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m ; j++)
                {

                    if (i + j == magicNum)
                    {
                        left = i;
                        right = j;
                        magic = true;

                    }
                    count++;
                }
            }

            if (magic)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", left, right, magicNum);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", count, magicNum);
            }

        }
    }
}
