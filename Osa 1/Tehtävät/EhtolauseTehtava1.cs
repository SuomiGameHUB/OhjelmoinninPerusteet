using System;

namespace EhtolauseHarjoitukset
{
    internal class Program
    {
        // Tehtävä 1: Hahmon ikä
        // Hahmon tulee olla vähintään 18-vuotias päästäkseen seikkailuun.
        // Täydennä ehtolause, joka tarkistaa, onko 'hahmonIka' vähintään 18.
        // Jos on, tulosta "Hahmo on tarpeeksi vanha seikkailuun!".
        // Muuten tulosta "Hahmo on liian nuori seikkailuun."

        static void Main(string[] args)
        {
            int hahmonIka = 17; // Voit muuttaa tätä arvoa testataksesi
            
            Console.WriteLine("Hahmon ikä: " + hahmonIka);

            // Kirjoita ehtolauseesi tähän alle:
            if (hahmonIka /* ??? */)
            {
                Console.WriteLine("Hahmo on tarpeeksi vanha seikkailuun!");
            }
            else
            {
                Console.WriteLine("Hahmo on liian nuori seikkailuun.");
            }

            Console.WriteLine("Paina Enter jatkaaksesi...");
            Console.ReadLine();
        }
    }
}
