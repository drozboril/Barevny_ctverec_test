using System;

namespace Barevný_čtverec_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte velikost čtverce od 3 do 30");
            int a = int.Parse(Console.ReadLine());

            Ošetření ošetření = new Ošetření();
            ošetření.Kontrola(a);
            Výpis výpis = new Výpis();
            Random b = new Random();
            
            výpis.Čtverec_Výpis(a, b);
            Console.ReadLine();
        }
    }
    class Ošetření
    {
        public int Kontrola(int a)
        {
            while (a < 3 || a > 30)
            {
                Console.WriteLine("Neplatný vstup");
                Console.ReadLine();
            }
            return a;
        }
    }
    class Výpis
    {
        public void Čtverec_Výpis(int a, Random b)
        {
            for (int i = 0; i < a; i++)
            {
                Console.ForegroundColor = (ConsoleColor)b.Next(14);
                Console.SetCursorPosition(40, 5 + i);
                for (int j = 0; j < a; j++)
                {
                    Console.Write("* ");
                }
            }
            return;
        }
    }
}