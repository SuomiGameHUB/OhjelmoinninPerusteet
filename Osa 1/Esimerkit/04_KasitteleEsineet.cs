using System;

namespace KasitteleEsineet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Oletetaan, että pelaajan inventaariossa on 7 esinettä.
            int esineidenMaara = 7;

            Console.WriteLine("Tarkistetaan inventaarion esineitä...");

            // Käydään läpi jokainen esine inventaariossa
            for (int i = 0; i < esineidenMaara; i++)
            {
                // Tässä voitaisiin esimerkiksi päivittää esineen tila, laskea sen paino, tai tarkistaa, onko se käytettävissä.
                Console.WriteLine("Käsitellään esine numero: " + (i + 1));
                // Kuvittele tässä kohtaa koodia, joka esim. tarkistaa esineen kestävyyden tai päivittää sen visuaalisen esityksen.
            }

            Console.WriteLine("Kaikki inventaarion esineet käsitelty.");
            Console.ReadLine();
        }
    }
}