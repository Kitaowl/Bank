using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_etap_pierwszy
{
    internal class KontoBankowe
    {
        private decimal _saldo;

        private string _numer = ""; // generowany automatycznie przy tworzeniu konta

        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        public string StanKonta()
        {
            return "Saldo: " + _saldo;
        }
    }
}