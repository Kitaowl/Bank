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

            automat.WrzucMonete(kontoBankowe, "0.5");

            // Wyświetlamy stan konta (jeszcze nie zrobione)
            Console.WriteLine(kontoBankowe.StanKonta());
        }
    }
}