using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade11_modificadores_atributos_metodos
{
    public class Divisao : Operacao
    {
        public override string Nome => "Divisao";

        public override string Id => "4";

        public override double Calculo(double valor1, double valor2)
        {
            return valor1 / valor2;
        }

        public override double InserirValor()
        {
            double valor = 0 ;
            bool valorValido = false;
            do
            {
                try
                {
                    Console.WriteLine($"Qual valor deseja {Nome}? ");
                    valor = double.Parse(Console.ReadLine());

                    valorValido = true;

                    if (valor == 0)
                    {
                        valorValido = false;
                        Console.WriteLine("divisão por 0 não é possível. digite outro número: ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Você digitou o valor errado. Digite um número");
                }
            } while (!valorValido);
            return valor;
        }
    }
}
