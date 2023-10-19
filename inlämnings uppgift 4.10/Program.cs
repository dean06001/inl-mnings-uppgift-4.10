using System;

namespace Uppgift_4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp vill du ha?");
            int nummerX = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O per grupp vill du ha?");
            int nummerO = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O mönster per rad vill du ha?");
            int nummerMönster = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många rader vill du ha?");
            int nummerRader = int.Parse(Console.ReadLine());

            for (int i = 0; i < nummerRader; i++)
            {
                string bobX = new string('X', nummerX);
                string bobO = new string('O', nummerO);
                string utbob = bobX + "-" + bobO + "-";
                string bobMönster = string.Concat(Enumerable.Repeat(utbob, nummerMönster));
                Console.WriteLine($"{bobMönster}{bobX}");
            }
            Console.ReadKey();
        }
    }
}