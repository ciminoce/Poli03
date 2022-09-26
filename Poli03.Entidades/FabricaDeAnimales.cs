using System;
using System.Collections.Generic;
using System.Text;

namespace Poli03.Entidades
{
    public class FabricaDeAnimales
    {
        public static Animal CrearAnimal(TiposDeAnimales tipo)
        {
            Animal animal = null;
            switch (tipo)
            {
                case TiposDeAnimales.Perro:
                    animal = new Perro("Jon");
                    break;
                case TiposDeAnimales.Gato:
                    animal = new Gato("Michi");
                    break;
                case TiposDeAnimales.FoxTerrier:
                    animal = new FoxTerrier("Bigote");
                    break;
                case TiposDeAnimales.GatoCallejero:
                    animal = new GatoCallejero("Chimenea");
                    break;
                default:
                    break;
            }
            return animal;
        }
    }
}
