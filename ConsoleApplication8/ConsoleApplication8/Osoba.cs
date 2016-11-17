using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;

        protected internal Osoba()
        {
            imie = "Brak";
            nazwisko = "Brak";
        }

        protected internal Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

    }
}
