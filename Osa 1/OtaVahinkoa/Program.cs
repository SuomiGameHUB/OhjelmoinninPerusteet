using System;

namespace OtaVahinkoa
{
    internal class Program
    {
        // Pelaajan elämäpisteet. Aloitetaan 100 pisteestä.
        static int pelaajanElama = 100;

        // Pelaajan vahingoittamisen metodi, jota kutsutaan muualta
        static void OtaVahinkoa()
        {
            int otettuVahinko = 60;
            pelaajanElama = pelaajanElama - otettuVahinko;
            Console.WriteLine("Pelaaja otti " + otettuVahinko + " vahinkoa. Elämää jäljellä: " + pelaajanElama);

            // Tarkistetaan, onko pelaaja kuollut
            if (pelaajanElama <= 0)
            {
                Console.WriteLine("Pelaajan elämä loppui! Peli päättyi.");
            }
            else
            {
                Console.WriteLine("Pelaaja on yhä elossa. Jatka taistelua!");
            }
        }

        // Päämetodi, josta ohjelman suoritus alkaa
        static void Main(string[] args)
        {
            Console.WriteLine("Pelaajan elämä alussa: " + pelaajanElama);

            // Vihollinen tekee vahinkoa
            OtaVahinkoa();

            // Otetaan lisää vahinkoa ja kokeillaan uudelleen
            OtaVahinkoa();

            Console.ReadLine(); // Pysäyttää konsolin, jotta näet tulosteen
        }
    }
}