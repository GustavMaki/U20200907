using System;
using System.Collections.Generic;
using System.Linq;

namespace U20200907._3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Skriv ditt citat här: ");
                string Citat = Console.ReadLine();

                string[] Words = Citat.Split(" ");
                int[] count = new int[Words.Length];

                foreach (string word in Words)
                {

                    for (int i = 0; i < Words.Length; i++)
                    {

                        for (int j = 0; j < Words.Length; j++)
                        {

                            if (Words[i] == Words[j])
                                count[i]++;
                        }

                        Console.WriteLine( Words[i] + " (" + count[i] + ")");
                    }

                    Console.ReadKey();
                }

            }
        }
    }
}

