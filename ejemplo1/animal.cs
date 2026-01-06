using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class animal
    {


        //ATRIBUTOS DE ANIMALES
        private string habitat;
        private string especie;


        //INICIALIZACION DEL OBJETO ANIMAL
        public animal() 
        {
            habitat = "planeta";
            especie = "indefinido";
        }


        //PROPIEDADES DE LOS ANIMALES
        public virtual string Habitat
        {
            get { return habitat; }
        }
        public virtual string Especie
        {
            get { return especie; }
        }

        //METODO DE ANIMAL
        public virtual string Comunicarse()
        {
            return "ruido de animal...";
        }
    }
}
