using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda vanus!");
            int Age = Convert.ToInt32(Console.ReadLine());

            if (Age >= 13)
            {
                Console.WriteLine("Tere tulemast! Sa oled piisavalt vana");
            }
            else
            {
                Console.WriteLine("Sa ei ole piisavalt vana");
            }

        }
    }
}
