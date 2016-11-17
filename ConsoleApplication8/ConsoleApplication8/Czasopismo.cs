using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Czasopismo : Pozycja
    {
        private int numer;

        public Czasopismo() { }

        public Czasopismo(int numer, string tytul, string wydawnictwo, int rokWydania, int id)
        {
            this.numer = numer;
            this.tytul = tytul;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.id = id;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Tytul: ", tytul);
            Console.WriteLine("Wydawnictwo: ", wydawnictwo);
            Console.WriteLine("Rok wydania: ", rokWydania);
            Console.WriteLine("Id: ", id);
            Console.WriteLine("Numer: ", numer);

        }
    }
}
