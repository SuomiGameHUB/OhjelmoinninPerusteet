using System;

namespace OlioTehtavat
{
    // Tehtävä 5: Luo uusi luokka nimeltä 'Vihollinen'.
    // Vihollisella on oltava oma konstruktori, joka asettaa sille nimen ja elämäpisteet (esim. 50).
    // Vihollisella on oltava metodi, joka hyökkää pelaajaa vastaan.
    // Tässä tehtävässä Pelaaja-luokka on jo valmiina.
    // Sinun tehtäväsi on luoda Vihollinen-luokka ja koodi Main-metodiin, joka saa vihollisen hyökkäämään pelaajaa vastaan.
    // Vihollisen hyökkäys tekee 10 vahinkoa pelaajalle.
    // Tulosta jokaisen hyökkäyksen jälkeen, paljonko pelaajalla on elämäpisteitä.
    // Peli loppuu, kun pelaajalla on 0 tai alle elämäpistettä.

    public class Pelaaja
    {
        public string nimi;
        public int elamaPisteet;

        public Pelaaja(string nimi, int elamaPisteet)
        {
            this.nimi = nimi;
            this.elamaPisteet = elamaPisteet;
        }

        public void OtaVahinkoa(int maara)
        {
            elamaPisteet -= maara;
        }
    }

    // Koodisi tähän alle


    // Koodisi tähän yläpuolelle

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
