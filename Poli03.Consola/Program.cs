using Poli03.Entidades;
using System;
using System.Collections.Generic;

namespace Poli03.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Perro p = new Perro("Gunnar");
            //Console.WriteLine(p.EmitirSonido());
            //Console.WriteLine(p.MostrarNombre());

            //FoxTerrier ft = new FoxTerrier("Cookie");
            //Console.WriteLine(ft.EmitirSonido());
            //GatoCallejero gc = new GatoCallejero("Chimenea");
            //Console.WriteLine(gc.EmitirSonido());

            Animal perro = FabricaDeAnimales.CrearAnimal(TiposDeAnimales.Perro);
            
            Console.WriteLine(perro.EmitirSonido());
            if (perro is Perro perro1)
            {
                Console.WriteLine(perro1.Jugar());
            }
            Animal gato = FabricaDeAnimales.CrearAnimal(TiposDeAnimales.Gato);
            Console.WriteLine(gato.EmitirSonido());

            Animal gatoCallejero = FabricaDeAnimales.CrearAnimal(TiposDeAnimales.GatoCallejero);

            List<Animal> animales = new List<Animal>();
            animales.Add(perro);
            animales.Add(gato);
            animales.Add(gatoCallejero);
            foreach (var animal in animales)
            {
                Console.WriteLine(animal.MostrarNombre());
            }
            Console.ReadLine();
        }
    }
}
