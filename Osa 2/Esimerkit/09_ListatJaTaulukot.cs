using System;
using System.Collections.Generic;

namespace ListatJaTaulukot
{
    public class Vihollinen
    {
        public void Paivita()
        {
            Console.WriteLine("Vihollisen sijainti päivitetty.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Luo lista ja lisää siihen muutamia vihollisia
            List<Vihollinen> vihollisetList = new List<Vihollinen>();
            vihollisetList.Add(new Vihollinen());
            vihollisetList.Add(new Vihollinen());
            vihollisetList.Add(new Vihollinen());

            Console.WriteLine("Käydään läpi lista.");

            // Päivitä kaikki viholliset yhdellä silmukalla
            foreach (Vihollinen vihollinen in vihollisetList)
            {
                vihollinen.Paivita();
            }

            Vihollinen[] vihollisetArray = new Vihollinen[5];
            vihollisetArray[0] = new Vihollinen();
            vihollisetArray[1] = new Vihollinen();

            Console.WriteLine("Käydään läpi taulukko.");

            // Päivitetään myös taulukon viholliset
            foreach (Vihollinen vihollinen in vihollisetArray)
            {
                // Tarkistetaan, onko alkiossa vihollinen
                if (vihollinen != null)
                {
                    vihollinen.Paivita();
                }
            }

            Console.WriteLine("Paina Enter lopettaaksesi.");
            Console.ReadLine();
        }
    }
}