using System;

namespace LoopTehtavat
{
    internal class Program
    {
        // Tehtävä: Pelaajan kokemuspisteet kasvavat tasaisesti. 
        // Jokainen taso vaatii 50 kokemuspistettä lisää kuin edellinen taso.
        // Aloita tasolta 1 (vaatii 50 XP tasolle 2).
        // Kuinka monta tasoa pelaaja saavuttaa, jos hänellä on yhteensä 500 kokemuspistettä?
        // Tulosta jokaisella tasolla, paljonko XP:tä tarvitaan seuraavalle tasolle.
        static int nykyinenTaso = 1;
        static int tarvittavaXP = 50;
        static int kerattyXP = 0; // Pelaajan keräämä kokonais-XP

        static void Main(string[] args)
        {
            // Käytä while-looppia. Loppuehto tulee olemaan, että kerätty XP ylittää asetetun rajan (500).
            // Loopin sisällä:
            // 1. Lisää nykyinenTasoa yhdellä.
            // 2. Lisää tarvittavaXPSeuraavalleTasolle-muuttujaan 50.
            // 3. Lisää kerttyXP-muuttujaan nykyisen tason vaatima XP.
            // 4. Tulosta paljonko XP:tä tarvitaan seuraavalle tasolle.

            // Koodisi tähän alle


            Console.WriteLine("Pelaaja saavutti tason: " + nykyinenTaso);
            Console.WriteLine("Paina Enter lopettaaksesi.");
            Console.ReadLine();
        }
    }
}
