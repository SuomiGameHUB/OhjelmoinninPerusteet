using System;

namespace EhtolauseHarjoitukset
{
    internal class Program
    {
        // Tehtävä 4: Questin tila
        // Pelaaja on suorittamassa questia.
        // Quest on valmis, jos 'esineKeratty' on totta JA 'vihollisetTapettu' on totta.
        // Jos quest on valmis, tulosta "Quest suoritettu! Palkinto odottaa.".
        // Jos esine on kerätty mutta viholliset eivät ole tapettu, tulosta "Keräsit esineen, mutta viholliset ovat yhä uhkana.".
        // Jos viholliset on tapettu mutta esinettä ei ole kerätty, tulosta "Viholliset on lyöty, mutta esine puuttuu yhä.".
        // Muuten tulosta "Quest on kesken."

        static void Main(string[] args)
        {
            bool esineKeratty = true; // Kokeile eri arvoja
            bool vihollisetTapettu = false; // Kokeile eri arvoja

            Console.WriteLine("Esine kerätty: " + esineKeratty);
            Console.WriteLine("Viholliset tapettu: " + vihollisetTapettu);

            // Ensimmäinen ehtolause:
            if (esineKeratty && vihollisetTapettu)
            {
                Console.WriteLine("Quest suoritettu! Palkinto odottaa.");
            }
            
            // Lisää else if -lohko tähän vastaamaan seuraavan tulosteen ehtoa:
            Console.WriteLine("Keräsit esineen, mutta viholliset ovat yhä uhkana.");

            // Lisää toinenkin else if -lohko vastaamaan seuraavan tulosteen ehtoa:
            Console.WriteLine("Viholliset on lyöty, mutta esine puuttuu yhä.");
            
            else
            {
                Console.WriteLine("Quest on kesken.");
            }


            Console.WriteLine("Paina Enter jatkaaksesi...");
            Console.ReadLine();
        }
    }
}
