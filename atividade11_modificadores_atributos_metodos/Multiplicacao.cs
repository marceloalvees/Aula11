using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade11_modificadores_atributos_metodos
{
    internal class Multiplicacao : Operacao
    {
        public override string Nome => "Multiplicação";

        public override string Id => "3";

        public override double Calculo(double valor1, double valor2)
        {
            return valor1 * valor2; 
        }
    }
}
