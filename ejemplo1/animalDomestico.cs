using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class animalDomestico : animal
    {
        private string nombre;
        private collar collar;
        private string domicilio;


        public animalDomestico()  //CONSTRUCTOR
        {
            nombre = "indefinido";
            collar = new collar(); //SE DEBE CREAR UN OBJETO TIPO COLLAR ASI TIENE DE REFERENCIA
        }


        public collar Collar { 

        get { return collar; }
            
        }
        public string Domicilio {

            get { return domicilio; }
            
            set { domicilio = value; } 
        }





        public virtual string Nombre // PROPIEDAD
        {
            get { return nombre; }
        }
    }
}
