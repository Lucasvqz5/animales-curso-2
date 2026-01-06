using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class collar
    {
        private string color;
        private string material;
        private string design;

        public collar()
        {
            color = "rojo";
            material = "goma";
            design = "liso";
        }

        public string Color { 
            get { return color; }
        }
        public string Material { 
            get { return material; }         
        }
        public string Design { 
            get { return design; }        
        }

    }
}
