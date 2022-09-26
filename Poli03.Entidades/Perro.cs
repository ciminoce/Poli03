using System;
using System.Collections.Generic;
using System.Text;

namespace Poli03.Entidades
{
    public sealed class Perro : Animal
    {
        public Perro(string Nombre) : base(Nombre)
        {

        }

        public override string EmitirSonido()
        {
            return "Guau";
        }

        public string Jugar()
        {
            return "Juega con un hueso";
        }
    }
}
