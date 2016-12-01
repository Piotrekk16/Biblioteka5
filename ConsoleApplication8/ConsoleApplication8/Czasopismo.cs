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

        public Czasopismo(int numer, string tytuł, string wydawnictwo, int rokWydania, int id)
            : base(tytuł, wydawnictwo, rokWydania, id) //szybciej i krocej z base
        {
            this.numer = numer;
        }

        public override void WypiszInfo() 
        {
            Console.WriteLine("Tytul: {0}", tytul); //brak odwołania do parametru
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok wydania: {0}", rokWydania);
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Numer: {0}", numer);

        }
    }
}
