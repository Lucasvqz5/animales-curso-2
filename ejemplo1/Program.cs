using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ANIMALES 
            //ANIMALES DOMESTICOS 
            //PERRO-GATO
            //ANIMALES SALVAJE
            //VACA-CABALLO
           
            
            //SE INICIAN LOS OBJETOS
            gato g1 = new gato();
            perro p1 = new perro();
            caballo c1 = new caballo();
            vaca v1 = new vaca();
            loro l1 = new loro();
            paloma pal1 = new paloma();

            //List<animal> animales = new List<animal>();  //COLECCION DE TIPO DE DATO ANIMAL
            //animales.Add(g1);
            //animales.Add(p1);
            //animales.Add(v1);
            //animales.Add(c1);
            //animales.Add(l1);
            //animales.Add(pal1);

            //List<Ivolar> animalesVoladores = new List<Ivolar>(); // COLECCION DE INTERFAZ `IVOLAR`
            //animalesVoladores.Add(l1);
            //animalesVoladores.Add(pal1);

            List<animalDomestico> domesticos = new List<animalDomestico>(); // COLECCION DE ANIMALES DOMESTICOS
            domesticos.Add(p1);
            domesticos.Add(g1);

            foreach (animalDomestico item in domesticos)
            {
                Console.WriteLine(item.Collar.Material);
            }

            //foreach(animalDomestico domestico in domesticos)
            //{
            //    Console.WriteLine("El collar que tiene el animal domestico es " + domestico.Collar);
            //}


            //foreach (animal item in animales)
            //{
            //    Console.WriteLine("Animal: " + item.Especie + " " + " Habitat: " +item.Habitat +" Sonido que produce:    "+ item.Comunicarse()); //POLIMORFISMO
            //}

            //foreach (animal voladores in animalesVoladores)
            //{
            //    Console.WriteLine(voladores + "Pueden volar");
            //}

            //foreach (var item in animales) {
            //    Console.WriteLine("Coloque el habitat del animal: ");
            //}
            //foreach (var item in animales)
            //{
            //    Console.WriteLine(item + " vive en: " + item.Habitat);
            //    Console.WriteLine(item.Comunicarse());
            //}

            //List<animalDomestico> domesticos = new List<animalDomestico>();
            //domesticos.Add(p1);
            //domesticos.Add(g1);

            //Console.WriteLine(domesticos[1].Especie +": "+domesticos[1].Habitat);
        }
    }
}
