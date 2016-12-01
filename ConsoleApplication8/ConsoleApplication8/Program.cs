using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Osoba o1 = new Osoba("Harry", "Potter");
            //Autor autor = new Autor("Karol", "Mieczysław", "Ostrołęka");

            //przerobiony program korzystający w całości z dobrodziejstw obiektówki
            Katalog biblioteka = new Katalog("Dział ogólny");
            biblioteka.DodajPozycje(new Czasopismo(1, "Harry Potter1", "Sowa", 1862, 2));
            biblioteka.DodajPozycje(new Czasopismo(2, "Harry Potter2", "Wydawnictwo Wrocław", 1995, 3));
            biblioteka.DodajPozycje(new Czasopismo(5, "Harry Potter3", "Wydawnictwo Kraków", 1994, 1));
            biblioteka.DodajPozycje(new Czasopismo(6, "Harry Potter4", "Wydawnictwo Wrocław", 1993, 7));
            biblioteka.DodajPozycje(new Czasopismo(6, "Harry Potter5", "Sowa", 1992, 7));

            biblioteka.DodajPozycje("Henryk", "Sienkiewicz", "Krzyżacy", 23, "Znak", 2010, 220);
            biblioteka.DodajPozycje("Władysław", "Reymont", "Chłopi", 31, "Greg", 2002, 310);
            
            biblioteka.DodajPozycje("Henryk", "Sienkiewicz", "Krzyżacy", 24, "Znak", 2011, 220);

            biblioteka.WypiszWszystko();

            Console.WriteLine("Wyszukiwanie po tytule");
            biblioteka.WyszukajPoTytule("Harry Potter5");

            Console.WriteLine("Wyszukiwanie po id");
            biblioteka.WyszukajPoId(1);



            Console.ReadKey();
        }
    }
}
