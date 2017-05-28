using System;



class Program
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        int sum = hours * 60 + minutes + 30;

        int hoursAfter30 = sum/60 <= 23 ? sum / 60 : sum / 60 - 24;
        int minutesAfter30 = sum % 60;
        Console.WriteLine("{0}:{1:D2}", hoursAfter30, minutesAfter30);
    }
}
