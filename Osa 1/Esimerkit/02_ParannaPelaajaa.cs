using System;

namespace ParannaPelaajaa
{
    internal class Program
    {
        // Muuttuja pitämään kirjaa pelaajan elämäpisteistä
        static int pelaajanElama = 50;

        // Metodi pelaajan parantamiseen
        static void ParannaPelaajaa()
        {
            int parannusMaara = 20; // Kuinka paljon elämää parannetaan
            pelaajanElama = pelaajanElama + parannusMaara; // Lisätään parannusmäärä nykyiseen elämään
            Console.WriteLine("Pelaajaa parannettiin! Uusi elämä: " + pelaajanElama);
        }

        // Päämetodi, josta ohjelman suoritus alkaa
        static void Main(string[] args)
        {
            Console.WriteLine("Elämä alussa: " + pelaajanElama);

            // Kutsutaan toimintoa "paranna" ensimmäisen kerran
            ParannaPelaajaa();

            // Kutsutaan toimintoa "paranna" toisen kerran
            ParannaPelaajaa();

            Console.ReadLine(); // Pysäyttää konsolin, jotta näet tulosteen
        }
    }
}