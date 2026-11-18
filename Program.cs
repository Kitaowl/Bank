using Bank;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KontoBankowe kontoBankowe = new KontoBankowe();
            Automat automat = new Automat();

            automat.WrzucMonety(kontoBankowe, "5 2 1 0.5 0.2 abc 3");

            string spamMonet = "";
            for (int i = 0; i < 15; i++) spamMonet += "5 ";
            automat.WrzucMonety(kontoBankowe, spamMonet.Trim());

            Console.WriteLine();
            Console.WriteLine(kontoBankowe.StanKonta());
            Console.WriteLine("Historia wpłat: " + kontoBankowe.PobierzHistorie());
            Console.WriteLine("Numer konta: " + kontoBankowe.Numer);
            automat.PokazMonety();
        }
    }
}