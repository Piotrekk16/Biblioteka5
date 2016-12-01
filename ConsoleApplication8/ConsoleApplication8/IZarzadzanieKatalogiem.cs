using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    interface IZarzadzanieKatalogiem // w tym przykładzie logicznie jest podpiąc interfejs do klasy a nie na odwrót
    {

        //tu dodajemy tylko deklarację (bez nawiasów klamrowych), przy dwóch metoda przydałyby się parametry
        void WyszukajPoTytule(string tytuł);
        void WyszukajPoId(int id);
        void WypiszWszystko();

    }
}
