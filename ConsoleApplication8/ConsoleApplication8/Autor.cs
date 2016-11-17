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
            narodowosc = "nieznana";
        }

        public Autor(string imie, string nazwisko, string narodowosc)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.narodowosc = narodowosc;
        }
    }
}
