using System;



    class Program
    {
        static void Main(string[] args)
        {
        //  Write a program, which reads a food product name, volume, energy content per 100ml 
        //and sugar content per 100ml.Calculate the energy and sugar content for 
        //the given volume and print them on the console in the following format:
        //•	Name – as per the input
        //•	Volume – integer, suffixed by “ml” (e.g. “220ml”)
        //•	Energy content – integer, suffixed by “kcal” (e.g. “500kcal”)
        //•	Sugar content – integer, suffixed by “g” (e.g. “30g”) 

        string name = Console.ReadLine();
        int volume = int.Parse(Console.ReadLine());
        int energy = int.Parse(Console.ReadLine());
        int sugar = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}ml {1}:", volume, name);
        Console.WriteLine("{0}kcal, {1}g sugars", 
            ((double)energy / 100) * volume, ((double)sugar/100)*volume);


    }
}

