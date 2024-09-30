using System;
using System.Linq;

namespace PeselToAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int century = 20;
            int currentYear = DateTime.Now.Year;
            Console.WriteLine("Podaj swój PESEL:");
            string pesel = Console.ReadLine();

            while (pesel.Length != 11 || !pesel.All(char.IsDigit))
            {
                if (pesel.Length != 11)
                {
                    Console.WriteLine("PESEL musi mieć 11 cyfr.");
                }
                else if (!pesel.All(char.IsDigit))
                {
                    Console.WriteLine("PESEL powinien zawierać tylko cyfry.");
                }
                pesel = Console.ReadLine();
            }

            if (pesel[2] == 2 || pesel[2] == 3)
            {
                century = 20;
            }
            else if (pesel[2] == 0 || pesel[2] == 1)
            {
                century = 19;
            }
            string rok = $"{century}{pesel[0]}{pesel[1]}";
            Console.WriteLine($"urodziles sie w {rok} i masz {currentYear - Convert.ToInt16(rok)}");
        }
    }
}
