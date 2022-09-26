using System;
using System.Collections.Generic;
using System.Text;

namespace Poli03.Entidades
{
    public class FoxTerrier : Animal
    {
        public FoxTerrier(string Nombre) : base(Nombre)
        {
        }

        public override string EmitirSonido()
        {
            return "Guau de FoxTerrier";
        }
    }
}
