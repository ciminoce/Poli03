using System;
using System.Collections.Generic;
using System.Text;

namespace Poli03.Entidades
{
    public class GatoCallejero : Gato
    {
        public GatoCallejero(string Nombre) : base(Nombre)
        {
        }
        public override string EmitirSonido()
        {
            return "Miau en los arrabales";
        }
    }
}
