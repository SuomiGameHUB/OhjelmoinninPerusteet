using System;

namespace YksinkertainenLaskin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yksinkertainen laskin");
            Console.WriteLine("Syötä ensimmäinen luku:");
            string luku1Teksti = Console.ReadLine();
            float luku1 = Single.Parse(luku1Teksti);

            Console.WriteLine("Syötä toinen luku:");
            string luku2Teksti = Console.ReadLine();
            float luku2 = Single.Parse(luku2Teksti);

            float summa = luku1 + luku2;

            Console.WriteLine("Summa on: " + summa);

            Console.WriteLine("Paina Enter lopettaaksesi.");
            Console.ReadLine();
        }
    }
}
