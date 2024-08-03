using System;


namespace Aantalflessen
{
    
    class Program
    {
        static void Main()
        {
            int aantalFlessen = 0;
            int aantalBakken = 0;

            Console.Write("Geef het aantal flesjes in: ");
             aantalFlessen = int.Parse(Console.ReadLine());

            while (aantalFlessen > 0) {

                aantalBakken++;
                aantalFlessen -= 24;
            }
            Console.WriteLine($"Aantal bakken nodig= {aantalBakken}");
        }
    }
}