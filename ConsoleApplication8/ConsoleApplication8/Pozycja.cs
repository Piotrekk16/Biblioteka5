using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    abstract class Pozycja
    {
        protected string tytul;
        protected string wydawnictwo;
        protected int rokWydania;
        protected int id;

        public Pozycja() { }
        public Pozycja(string tytul, string wydawnictwo, int rokWydania, int id)
        {
            this.tytul = tytul;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.id = id;
        }

        abstract public void WypiszInfo();
    }
}
