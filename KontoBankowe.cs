using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_etap_pierwszy
{
    internal class KontoBankowe
    {
        private decimal _saldo;

        //private string _numer; // generowany automatycznie przy tworzeniu konta
        
        public decimal Saldo
        {
            get { return _saldo; }
            private set { _saldo = value; }
        }

        public void Wplac(decimal kwota)
        {
            Saldo += kwota;
        }

        public string StanKonta()
        {
            return "Saldo: " + _saldo;
        }

        private static int _licznikKont = 0;
        private readonly string _numer;

        public KontoBankowe()
        {
            _licznikKont++;
            _numer = "KONTO-" + _licznikKont;
        }

        public string Numer
        {
            get { return _numer; }
        }
    }
}