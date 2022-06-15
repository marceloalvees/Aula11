using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade11_modificadores_atributos_metodos
{
    public class Zerar : Operacao
    {
        public override string Id => "5";

        public override string Nome => "Zerar";

        public override double Calculo(double valor1, double valor2)
        {
            return 0;
        }

        public override double Executar(double resultado)
        {
            PrintInicio();
            return 0;
        }
    }
}
