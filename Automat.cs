using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Bank_etap_pierwszy
{
    internal class Automat
    {
        private readonly Dictionary<decimal, int> _iloscMonet = new Dictionary<decimal, int>();
        private readonly decimal[] _przyjmowaneMonety = new decimal[] { 5, 2, 1, 0.5m, 0.2m, 0.1m };

        // Stwórz metodę WrzucMonete
        public Automat()
        {
            foreach (decimal nominal in _przyjmowaneMonety)
            {
                _iloscMonet[nominal] = 0;
            }
        }
        public void WrzucMonete(KontoBankowe konto, string moneta)
        {
            // Sprawdzamy czy monetę da się W OGÓLE sparsować na jakiś decimal
            string monetaUjednoliconyZapis = moneta.Replace(",", ".");
            bool czyUdanyParse = decimal.TryParse(monetaUjednoliconyZapis, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal wartoscMonety);

            if (!czyUdanyParse)
            {
                Console.WriteLine("Nieudany odczyt monety.");
                return;
            }

            bool czyPrzyjeta = false;

            // Sprawdź czy monety są z zakresu _przyjmowaneMonety
            foreach (decimal nominal in _przyjmowaneMonety)
            {
                // jeżeli tak, to zwiększ saldo konta i ilość monet w automacie
                if (wartoscMonety == nominal)
                {
                    konto.Wplac(nominal);
                    _iloscMonet[nominal]++;
                    Console.WriteLine("Moneta przyjęta: " + nominal);
                    czyPrzyjeta = true;
                }
            }
            if (!czyPrzyjeta)
            {
                Console.WriteLine("Takiej monety nie znam.");
            }
        }
    public void PokazMonety()
        {
            decimal sumaWszystkich = 0;
            Console.WriteLine("Stan monet w automacie:");
            foreach (var kvp in _iloscMonet)
            {
                Console.WriteLine($"Nominał {kvp.Key} zł: {kvp.Value} szt.");
                sumaWszystkich += kvp.Key * kvp.Value;
            }
            Console.WriteLine($"Łączna wartość wszystkich monet: {sumaWszystkich} zł");
        }
    }
}