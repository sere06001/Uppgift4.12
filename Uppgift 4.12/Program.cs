using System;
namespace Uppgift4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bestäm kvadraternas sidlängd");
            int kvadratSidlängd = int.Parse(Console.ReadLine());
            Console.WriteLine("Bestäm rutnätets bredd");
            int rutnätBredd = int.Parse(Console.ReadLine());
            Console.WriteLine("Bestäm rutnätets höjd");
            int rutnätHöjd = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int antalKvadrater = 0; antalKvadrater < rutnätHöjd; antalKvadrater++)
            {
                for (int i = 0; i < kvadratSidlängd; i++)
                {
                    string FemStjärnor = "***** ";
                    string utskrivet = string.Concat(Enumerable.Repeat(FemStjärnor, rutnätBredd));
                    Console.WriteLine($"{utskrivet}");
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}