using System;

namespace OlioTehtavat
{
    // Tehtävä 4: Lisää 'Pelaaja'-luokkaan kaksi metodia:
    // 1. OtaVahinkoa(int maara): Vähentää elamaPisteet-muuttujaa annetulla määrällä.
    // 2. Kuole(): Tulostaa viestin "Pelaaja on kuollut!"
    // Muuta Main-metodin koodia niin, että se kutsuu näitä uusia metodeja.
    // Testaa, että pelaaja kuolee, jos elämäpisteet menevät alle nollan.

    public class Pelaaja
    {
        public string nimi;
        public int elamaPisteet;

        public Pelaaja(string nimi, int elamaPisteet)
        {
            this.nimi = nimi;
            this.elamaPisteet = elamaPisteet;
        }

        // Koodisi tähän alle


        // Koodisi tähän yläpuolelle
    }

    static class Program
    {
        static void Main(string[] args)
        {
            Pelaaja sankarimme = new Pelaaja("Heikki", 100);

            // Koodisi tähän alle


            // Koodisi tähän yläpuolelle
            Console.WriteLine("Paina Enter lopettaaksesi.");
            Console.ReadLine();
        }
    }

}
