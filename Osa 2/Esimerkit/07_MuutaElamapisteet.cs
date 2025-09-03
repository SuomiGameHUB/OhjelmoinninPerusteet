using System;

namespace MuutaElamapisteet
{
    public class Pelaaja
    {
        private int elamapisteet = 100;
        private int maksimiElama = 100;

        public Pelaaja()
        {
            Console.WriteLine("Pelaajan elämä: " + elamapisteet + ".");
        }

        public void MuutaElamapisteita(int muutos)
        {
            elamapisteet += muutos;

            if (elamapisteet > maksimiElama)
            {
                elamapisteet = maksimiElama;
            }
            Console.WriteLine("Pelaajan elämä: " + elamapisteet + ".");
        }
    }

    public class Vihollinen
    {
        public void Hyokkaa(Pelaaja kohde)
        {
            Console.WriteLine("Vihollinen hyökkää.");
            kohde.MuutaElamapisteita(-10);
        }
    }

    public class Parannusesine
    {
        public void Kayta(Pelaaja kohde)
        {
            Console.WriteLine("Parannusesine käytetty.");
            kohde.MuutaElamapisteita(20);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pelaaja pelaaja1 = new Pelaaja();
            Vihollinen zombi = new Vihollinen();
            Parannusesine korvapuusti = new Parannusesine();

            zombi.Hyokkaa(pelaaja1);
            zombi.Hyokkaa(pelaaja1);
            korvapuusti.Kayta(pelaaja1);

            Console.WriteLine("Paina Enter lopettaaksesi.");
            Console.ReadLine();
        }
    }
}