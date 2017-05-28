using System;


namespace wordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string singular = Console.ReadLine();
            

            if (singular[singular.Length-1] == 'y')
            {
                singular = singular.Remove(singular.Length - 1);
                singular += "ie";

            }
            else if (singular[singular.Length - 1] == 'o' || singular[singular.Length - 1] == 's'
                || singular[singular.Length - 1] == 'x' || singular[singular.Length - 1] == 'z')
            {
                singular += 'e';
            }
            else if ((singular[singular.Length - 2] == 'c' || singular[singular.Length - 2] == 's') 
                && singular[singular.Length - 1] == 'h')
            {
                singular += 'e';
            }

            Console.WriteLine(singular+ 's');

        }
    }
}
