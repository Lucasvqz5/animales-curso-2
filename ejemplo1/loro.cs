using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class loro : animalSalvaje, Ivolar //VOLAR ES UNA INTERFAZ
    {
        public string fly()  //METODO DE LA INTERFAZ ( CONTRATO )
        {
            return "Puede volar";
        }
    }
}
