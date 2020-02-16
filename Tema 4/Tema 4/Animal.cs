using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4
{
    class Animal
    {
        public string tipAnimal { get; set; }
        public string culoare { get; set; }
        public int varsta { get; set; }

        public Animal(string _tipAnimal)
        {
            this.tipAnimal = _tipAnimal;
        }

        public Animal(string _tipAnimal, string _culoare)
        {
            this.tipAnimal = _tipAnimal;
            this.culoare = _culoare;
        }

        public Animal(string _tipAnimal, string _culoare, int _varsta)
        {
            this.tipAnimal = _tipAnimal;
            this.culoare = _culoare;
            this.varsta = _varsta;
        }

       
    }
}
