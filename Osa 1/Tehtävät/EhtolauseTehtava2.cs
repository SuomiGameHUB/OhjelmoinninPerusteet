using System;

namespace EhtolauseHarjoitukset
{
    internal class Program
    {
        // Tehtävä 2: Ovi aukeaa
        // Pelaaja yrittää avata oven. Ovi aukeaa, jos 'onAvain' on totta.
        // Muuta 'onAvain' arvoa ja täydennä ehtolause.
        // Jos pelaajalla on avain, tulosta "Ovi aukeaa ja pääset eteenpäin!".
        // Muuten tulosta "Tarvitset avaimen avataksesi oven."

        static void Main(string[] args)
        {
             // luo onAvain -muuttuja

            Console.WriteLine("Pelaajalla on avain: " + onAvain);

            // Kirjoita ehtolauseesi tähän alle:
            if ()
            {
                Console.WriteLine("Ovi aukeaa ja pääset eteenpäin!");
            }
            else
            {
                Console.WriteLine("Tarvitset avaimen avataksesi oven.");
            }

            Console.WriteLine("Paina Enter jatkaaksesi...");
            Console.ReadLine();
        }
    }
}