using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    //Struct = Armazena o valor na memória
    //Classe = Referencia um objeto que está salvo na memória
    struct Polegada {

        double polegada;

        public Polegada(double centimetro)
        {
            polegada = centimetro * 2.54;
        }

        public override string ToString()
        {
            return polegada.ToString();
        }
    }
}
