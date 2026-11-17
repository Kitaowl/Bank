using Bank_etap_pierwszy;

namespace Bank_etap_pierwszy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie konta
            KontoBankowe kontoBankowe = new KontoBankowe();

            // Tworzenie automatu do wpłat
            Automat automat = new Automat();

            automat.WrzucMonete(kontoBankowe, "5");
            automat.WrzucMonete(kontoBankowe, "2");
            automat.WrzucMonete(kontoBankowe, "1");
            automat.WrzucMonete(kontoBankowe, "0.5");
            automat.WrzucMonete(kontoBankowe, "0.2");
            automat.WrzucMonete(kontoBankowe, "3");
            automat.WrzucMonete(kontoBankowe, "asd");

            Console.WriteLine();

            Console.WriteLine(kontoBankowe.StanKonta());
            Console.WriteLine("Numer konta: " + kontoBankowe.Numer);
            automat.PokazMonety();

            Console.WriteLine();

            KontoBankowe drugieKonto = new KontoBankowe();
            Console.WriteLine("Numer drugiego konta: " + drugieKonto.Numer);
        }
    }
}