using System;

namespace LoopTehtavat
{
    internal class Program
    {
        // Tehtävä: Pelaaja kerää 5 resurssia. Tulosta jokaisen keräyksen jälkeen "Resurssi kerätty!"
        static void Main(string[] args)
        {
            // Muokkaa alla olevaa for-looppia niin, että se toistuu 5 kertaa.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Resurssi kerätty!");
            }

            Console.WriteLine("Paina Enter lopettaaksesi.");
            Console.ReadLine();
        }
    }
}