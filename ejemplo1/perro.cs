using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class perro : animalDomestico
    {
        private string habitat;
        private string especie;
        public perro()
        {
            habitat = "casa";
            especie = "perro";
        }

        public override string Habitat
        {
            get { return habitat; }
        }
        public override string Especie
        {
            get { return especie; }
        }


        public override string Comunicarse()
        {
            return "guau guau...";
        }
    }
}
