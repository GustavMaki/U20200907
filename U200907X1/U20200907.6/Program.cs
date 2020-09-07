using System;

namespace U20200907._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal mellan 1-21: ");
            
            int i = 0;

            for (i = 0; i < 100; i++)
            {
                Random Random = new Random();
                int Rand = Random.Next(1, 21);
                string Tal = Console.ReadLine();
                int Number = Int32.Parse(Tal);

                Console.WriteLine("Ditt tal är: "+Number);
                Console.WriteLine("Rätt tal är: "+Rand);

                if (Number == Rand)
                {
                    Console.WriteLine("Grattis du gissade rätt!");
                    break; 
                }

                else
                {
                    Console.WriteLine("Fel! Gissa ett tal mellan 1-21: ");
                    continue;
                }

            }

        }
    }
}
