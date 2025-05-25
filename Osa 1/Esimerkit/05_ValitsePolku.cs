using System;

namespace ValitsePolku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olet risteyksessä. Mihin suuntaan haluat mennä?");
            Console.WriteLine("1. Idän puoleinen polku");
            Console.WriteLine("2. Lännen puoleinen polku");
            Console.WriteLine("3. Palaa takaisin kylään");

            int pelaajanValinta = 0;
            bool valintaKelvollinen = false;

            // Kysy pelaajalta valintaa niin kauan kuin valinta ei ole kelvollinen
            while (!valintaKelvollinen)
            {
                Console.Write("Syötä valintasi (1-3): ");
                string syoteTekstina = Console.ReadLine(); // Luetaan käyttäjän syöte tekstinä

                // int.TryParse yrittää muuntaa tekstin numeroksi turvallisesti.
                // Jos muunnos onnistuu, 'pelaajanValinta' saa arvon ja ehto on tosi.
                if (int.TryParse(syoteTekstina, out pelaajanValinta))
                {
                    // Tarkistetaan, onko numero sallittujen rajojen sisällä (1, 2 tai 3)
                    if (pelaajanValinta >= 1 && pelaajanValinta <= 3)
                    {
                        valintaKelvollinen = true; // Valinta on kelvollinen, silmukka voi päättyä
                    }
                    else
                    {
                        Console.WriteLine("Virheellinen valinta. Syötä numero 1, 2 tai 3.");
                    }
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte. Syötä numero, älä tekstiä.");
                }
            }

            Console.WriteLine("Valitsit vaihtoehdon numero: " + pelaajanValinta);

            // Tässä kohtaa peli jatkuisi pelaajan valinnan mukaisesti
            if (pelaajanValinta == 1)
            {
                Console.WriteLine("Lähdet idän puoleista polkua pitkin...");
            }
            else if (pelaajanValinta == 2)
            {
                Console.WriteLine("Suuntaat lännen puoleista polkua pitkin...");
            }
            else if (pelaajanValinta == 3)
            {
                Console.WriteLine("Palaat takaisin kylään...");
            }

            Console.ReadLine();
        }
    }
}