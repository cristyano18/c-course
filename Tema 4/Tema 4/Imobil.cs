using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4
{
    class Imobil
    {
        public string tipCasa { get; set; }
        public string nrEtaje { get; set; }

        public double pret { get; set; }

        public Imobil()
        {
            
        }

        public Imobil(string _tipCasa, string _nrEtaje, double _pret)
        {
            this.tipCasa = _tipCasa;
            this.nrEtaje = _nrEtaje;
            this.pret = _pret;
        }

        public Imobil(string _tipCasa)
        {
            this.tipCasa = _tipCasa;
        }
    }
}
