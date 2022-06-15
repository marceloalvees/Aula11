using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade11_modificadores_atributos_metodos
{
    public class Subtracao : Operacao
    {

        public override string Nome => "Subtração";

        public override string Id => "2";

        public override double Calculo(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
    }
}
