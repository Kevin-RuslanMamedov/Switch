using System;

namespace ControlFlow2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere! Sisesta PIN");
            int Pin = Convert.ToInt32(Console.ReadLine());

            if (Pin == 1234)
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale PIN, proovi uuesti.");
            }

        }
    }
}
