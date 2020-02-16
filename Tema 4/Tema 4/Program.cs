using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal pisica = new Animal("pisica");

            Animal caine = new Animal("maidanez", "negru");

            Animal bou = new Animal("olandez", "mov", 30);

            Imobil casa = new Imobil();
            casa.tipCasa = "P+M";
            casa.nrEtaje = "1";
            casa.pret = 45000;

            Imobil mansarda = new Imobil("Mansarda");

        }
    }
}
