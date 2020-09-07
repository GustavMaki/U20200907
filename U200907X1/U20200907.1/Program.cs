using System;

namespace U20200907._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int i = 0;
            int WordCount = 1;

            Console.WriteLine("Skriv ditt citat här: ");
            string Citat = Console.ReadLine();

            while (n <= Citat.Length - 1)
            {
                if (Citat[n] == ' ')
                {
                    WordCount++;
                }
                n++;
            }

            Console.WriteLine("Antalet ord i ditt citat är: " + WordCount);
            string[] Words = Citat.Split(" ");
        }
    }
}
