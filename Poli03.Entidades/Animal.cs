using System;

namespace Poli03.Entidades
{
    public abstract class Animal
    {
        private string nombre;
        public Animal(string Nombre )
        {
            nombre = Nombre;
        }
        public abstract string EmitirSonido();

        public string MostrarNombre() => nombre;
    }
}
