using System;
using System.Collections.Generic;
using System.Text;

namespace Poli03.Entidades
{
    public class Gato : Animal
    {
        public Gato(string Nombre):base(Nombre)
        {

        }
        public override string EmitirSonido()
        {
            return "Miau";
        }
    }
}
