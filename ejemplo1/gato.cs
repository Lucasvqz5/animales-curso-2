using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class gato : animalDomestico
    {
        private string habitat;
        private string especie;


        public gato() {
            habitat = "casa";
            especie = "gato";
        }


        public override string Especie
        {
            get { return especie; }
        }
        public override string Habitat
        {
            get { return habitat; }
        }



        public override string Comunicarse()
        {
            return "miau...";
        }

    }
}
