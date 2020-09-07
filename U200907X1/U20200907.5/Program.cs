using System;
using System.Globalization;

namespace U20200907._5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] Word = new string[100];
            int i = 0;
            int j = 0;

            for (i = 0; i<100; i++) { 
           
                Console.WriteLine("Skriv ett ord: ");
                Word[i] = Console.ReadLine();


                if (Word[i] == "AVSLUTA")
                {
                    Word[i] = ".";
                    break;
                    
                }
                else {
                    continue;
                }

            }
            Console.Write("Din mening är: ");

            for (j = 0; j < Word.Length; j++) {
                Console.Write(Word[j]+ " ");

            }

            }

        }
    }

