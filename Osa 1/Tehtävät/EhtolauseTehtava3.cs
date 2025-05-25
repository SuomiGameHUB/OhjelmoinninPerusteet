using System;

namespace EhtolauseHarjoitukset
{
    internal class Program
    {
        // Tehtävä 3: Hirviön vahinko
        // Hirviö tekee vahinkoa pelaajalle.
        // Jos hirviön hyökkäysvoima on yli 15, se tekee "Suurta vahinkoa".
        // Jos se on yli 5, mutta enintään 15, se tekee "Normaalia vahinkoa".
        // Muuten se tekee "Pientä vahinkoa".
        // Tulosta sopiva viesti sen mukaan, millaista vahinkoa hirviö tekee.

        static void Main(string[] args)
        {
            int hirvionHyokkaysVoima = 12; // Kokeile eri arvoja, esim. 3, 8, 20

            Console.WriteLine("Hirviön hyökkäysvoima: " + hirvionHyokkaysVoima);

            // Kirjoita ehtolauseesi tähän alle:
            if ()
            {
                Console.WriteLine("Hirviö tekee suurta vahinkoa!");
            }
            else if ()
            {
                Console.WriteLine("Hirviö tekee normaalia vahinkoa.");
            }
            else
            {
                Console.WriteLine("Hirviö tekee pientä vahinkoa.");
            }

            Console.WriteLine("Paina Enter jatkaaksesi...");
            Console.ReadLine();
        }
    }
}