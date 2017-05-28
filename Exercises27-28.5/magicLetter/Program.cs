using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	First line – lower case English letter from ‘a’ to ‘z’
            //•	Second line – lower case English letter from ‘a’ to ‘z’
            //•	Third line – lower case English letter from ‘a’ to ‘z’ – combinations, containing this letter should not be printed

            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char ignore = char.Parse(Console.ReadLine());

            for (char i = start; i <= end  ; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        if (k != ignore && j != ignore && i != ignore) 
                        Console.Write("{0}{1}{2} ", i, j, k);
                    }
                }
                
            }
            Console.WriteLine();

        }
    }
}
