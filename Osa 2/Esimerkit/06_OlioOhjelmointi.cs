using System;

namespace OlioOhjelmointi
{
    public class Vihollinen
    {
        // Luokan ominaisuudet (properties) eli muuttujat, jotka kuvaavat vihollista
        public int elamapisteet;
        public string nimi;
        public float nopeus;

        // Konstruktori on metodi, jolla on sama nimi kuin luokalla
        public Vihollinen(string alkunimi, int alkuelama, float alkunopeus)
        {
            nimi = alkunimi;
            elamapisteet = alkuelama;
            nopeus = alkunopeus;
        }

        // Luokan metodi eli toiminto, jonka vihollinen voi tehdä
        public void Liiku()
        {
            // Koodi, joka liikuttaa vihollista
            Console.WriteLine("Vihollinen " + nimi + " liikkuu nopeudella " + nopeus + ".");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Täällä ei tarvitse asettaa muuttujia erikseen
            Vihollinen zombi = new Vihollinen("Zombi", 100, 1.5f);
            Vihollinen luuranko = new Vihollinen("Luuranko", 80, 2.0f);

            zombi.Liiku();
            luuranko.Liiku();

            Console.WriteLine("Paina Enter lopettaaksesi.");
            Console.ReadLine();
        }
    }
}