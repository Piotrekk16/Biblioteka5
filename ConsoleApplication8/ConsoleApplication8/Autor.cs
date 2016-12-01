using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Autor : Osoba
    {
        private string narodowosc;
        public Autor()
        {
            narodowosc = "polska"; //konkret!
        }

        public Autor(string imie, string nazwisko, string narodowosc)
            : base(imie, nazwisko) //lepiej uzyc base
        {
           this.narodowosc = narodowosc;
        }

        //konstruktor z 2 parametrami (bez narodowosci) 
        public Autor(string imie, string nazwisko)
            : base(imie, nazwisko)
        {
            narodowosc = "Polska";
        }

        public string PobierzAutora()
        {
            return imie + " " + nazwisko;
        }
    }
}
