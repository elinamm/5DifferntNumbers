using System;

namespace neighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damageToGosho = int.Parse(Console.ReadLine());
            int damageToPesho = int.Parse(Console.ReadLine());

            int Pesho = 100;
            int Gosho = 100;

            int count = 0;

            do
            {
                count++;

                if (count % 2 != 0) // Pesho attacks Gosho
                {
                    if (Gosho - damageToGosho <= 0)
                    {
                        Gosho -= damageToGosho;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", Gosho - damageToGosho);
                        Gosho -= damageToGosho;
                    }
                }
                else // Gosho attacks Pesho
                {
                    if (Pesho - damageToPesho <= 0)
                    {
                        Pesho -= damageToPesho;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", Pesho - damageToPesho);
                        Pesho -= damageToPesho;
                    }
                }
                if (count % 3 == 0)
                {
                    Pesho += 10;
                    Gosho += 10;
                }
            } while (Pesho > 0 && Gosho > 0);

            Console.WriteLine("{0} won in {1}th round.", Pesho - damageToPesho > Gosho - damageToGosho ? "Pesho" : "Gosho", count);
        }
    }
}
