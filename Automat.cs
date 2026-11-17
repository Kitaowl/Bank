using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Bank_etap_pierwszy
{
    internal class Automat
    {
        private int _iloscMonet;
        private readonly decimal[] _przyjmowaneMonety = new decimal[] { 5, 2, 1, 0.5m, 0.2m, 0.1m };

        // Stwórz metodę WrzucMonete
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

            // Sprawdź czy monety są z zakresu _przyjmowaneMonety
            foreach (decimal nominal in _przyjmowaneMonety)
            {
                // jeżeli tak, to zwiększ saldo konta i ilość monet w automacie
                if (wartoscMonety == nominal)
                {
                    konto.Saldo += nominal;
                    _iloscMonet++;
                }
            }
        }
    }
}