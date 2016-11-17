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
            Osoba o1 = new Osoba("Harry", "Potter");
            Autor autor = new Autor("Karol", "Mieczysław", "Ostrołęka");
            List<Czasopismo> Czasopisma = new List<Czasopismo>();
            Czasopisma.Add(new Czasopismo(1, "Harry Potter1", "Sowa", 1862, 2));
            Czasopisma.Add(new Czasopismo(2, "Harry Potter2", "Wydawnictwo Wrocław", 1995, 3));
            Czasopisma.Add(new Czasopismo(5, "Harry Potter3", "Wydawnictwo Kraków", 1994, 1));
            Czasopisma.Add(new Czasopismo(6, "Harry Potter4", "Wydawnictwo Wrocław", 1993, 7));
            Czasopisma.Add(new Czasopismo(6, "Harry Potter5", "Sowa", 1992, 7));





            Console.ReadKey();
        }
    }
}
