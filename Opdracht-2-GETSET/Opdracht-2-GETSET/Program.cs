using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Breuk breuk = new Breuk();

            Opvraging(breuk);

            Console.WriteLine("Het quotient is: {0}", Quotient(breuk));
            Console.ReadLine();
        }
        private static void Opvraging(Breuk breuk)
        {
            Console.Write("Geef de teller in: ");
            breuk.Teller = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef de noemer in: ");
            breuk.Teller = Convert.ToDouble(Console.ReadLine());
        }
        private static double Quotient(Breuk breuk)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            return breuk.Teller / breuk.Noemer;
        }
    }
}
