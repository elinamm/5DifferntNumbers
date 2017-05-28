using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characterStars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which displays information about a video game character.
            //You will receive their name, current health, maximum health, 
            //current energy and maximum energy on separate lines. 
            //The current values will always be valid(equal or lower than their respective max values).
            // Print them in the format as per the examples

            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", 
                new string ('|', health), new string ('.', maxHealth-health));
            Console.WriteLine("Energy: |{0}{1}|", 
                new string ('|', energy), new string('.', maxEnergy-energy));
        }
    }
}
