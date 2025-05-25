using System;

namespace EhtolauseHarjoitukset
{
    internal class Program
    {
        // Tehtävä 5: Kaupankäynti
        // Pelaaja yrittää ostaa esineen kaupasta.
        // Hänellä pitää olla tarpeeksi kolikoita ja tarvittaessa "erikoislupa".
        // - Jos pelaajalla on vähintään 100 kolikkoa JA 'onErikoislupa' on totta,
        //   hän voi ostaa "Legendaarisen miekan". Tulosta viesti tästä.
        // - Muuten, jos pelaajalla on vähintään 50 kolikkoa (mutta ei erikoislupaa tai ei tarpeeksi kolikoita legendaariseen miekkaan),
        //   hän voi ostaa "Teräksisen rintapanssarin". Tulosta viesti tästä.
        // - Muuten, jos pelaajalla on vähintään 10 kolikkoa,
        //   hän voi ostaa "Puinen kilpi". Tulosta viesti tästä.
        // - Jos pelaajalla on alle 10 kolikkoa, tulosta "Ei tarpeeksi kolikoita mihinkään esineeseen.".

        static void Main(string[] args)
        {
            int pelaajanKolikot = 75; // Kokeile eri arvoja, esim. 5, 25, 60, 120
            bool onErikoislupa = false; // Kokeile true/false
            
            Console.WriteLine("Pelaajan kolikot: " + pelaajanKolikot);
            Console.WriteLine("Pelaajalla erikoislupa: " + onErikoislupa);

            // Kirjoita ehtolauseesi tähän alle:


            Console.WriteLine("Paina Enter lopettaaksesi.");
            Console.ReadLine();
        }
    }
}
