using System;

namespace LoopTehtavat
{
    internal class Program
    {
        // Tehtävä: Pelaajan energiapalkki alkaa 100 pisteestä. 
        // Joka kierroksella energiaa kuluu 10 pistettä.
        // Kuinka monta kierrosta pelaaja voi pelata ennen kuin energia loppuu (menee alle 0)?
        // Tulosta jokaisella kierroksella jäljellä oleva energia.
        static double energia = 100.0; // Pelaajan energia
        static int kierrokset = 0;     // Pelattujen kierrosten määrä

        static void Main(string[] args)
        {
            // Käytä while-looppia. Loppuehto tulee olemaan "niin kauan kuin energiaa on jäljellä".
            // Loopin sisällä vähennä energiaa 20.0:lla ja kasvata kierrokset-muuttujaa.
            // Tulosta jäljellä oleva energia jokaisen kierroksen jälkeen.

            // Koodisi tähän alle


            Console.WriteLine($"Kierroksia pelattu ennen energian loppumista: " + kierrokset);

            Console.WriteLine("Paina Enter lopettaaksesi.");
            Console.ReadLine();
        }
    }
}