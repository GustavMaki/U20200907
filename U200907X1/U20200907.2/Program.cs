using System;

namespace U20200907._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt citat här: ");
            string Citat = Console.ReadLine();

            string[] Words = Citat.Split(" ");

            Array.Reverse(Words);

            Console.WriteLine("Omvänd ordning:");

            foreach (var word in Words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Storleksordning:");

            Array.Sort(Words, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string word in Words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
