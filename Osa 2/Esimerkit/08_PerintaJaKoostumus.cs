using System;

namespace PerintaJaKoostumus
{
    public class Hahmo
    {
        public Ase ase;

        // Huomaa parametrina tuleva ase
        public Hahmo(Ase annettavaAse)
        {
            ase = annettavaAse;
        }

        public void Ammu()
        {
            // Kutsuu spesifin aseen omaa laukaisumekaniikkaa.
            ase.Laukaise();
        }
    }

    public class Ase
    {
        public float paino;
        public int vahinko;

        public virtual void Laukaise()
        {
            // Yleinen laukaisulogikka, jos lapsiluokka ei ole ylikirjoittanut sitä
            Console.WriteLine("Ase laukaistiin!");
        }
    }

    public class Pistooli : Ase
    {
        public int luotienMaara;

        // Ylikirjoittaa laukaisulogiikan pistoolille.
        public override void Laukaise()
        {
            Console.WriteLine("Pistooli laukaistiin.");
        }
    }

    public class Haulikko : Ase
    {
        public int haulikonKantama;

        // Ylikirjoittaa laukaisulogiikan haulikolle.
        public override void Laukaise()
        {
            Console.WriteLine("Haulikko laukaistiin.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Ase pistooli = new Pistooli();
            Ase haulikko = new Haulikko();
            Hahmo pelaaja1 = new Hahmo(haulikko);

            pelaaja1.Ammu();

            // Vaihdetaan asetta
            pelaaja1.ase = pistooli;
            pelaaja1.Ammu();

            Console.WriteLine("Paina Enter lopettaaksesi.");
            Console.ReadLine();
        }
    }
}