namespace atividade11_modificadores_atributos_metodos
{
    public abstract class Operacao
    {
        public abstract string Id { get; }
        public abstract string Nome { get; }
        public abstract double Calculo(double valor1, double valor2);
        public virtual double InserirValor()
        {
            double valor = 0;
            bool valorValido = false;
            do
            {
                try
                {
                    Console.WriteLine($"Qual valor deseja {Nome}? ");
                    valor = double.Parse(Console.ReadLine());
                    valorValido = true;

                }
                catch (Exception)
                {
                    Console.WriteLine("Você digitou o valor errado. Digite um número");
                }
            } while (!valorValido);

            return valor;
        }

        public void Print(double valor)
        {
            Console.WriteLine($"O resultado é : {valor} ");
        }

        public void PrintInicio()
        {
            Console.WriteLine($"Você digitou {Id} - {Nome} ");
        }

        public virtual double Executar(double resultado)
        {
            PrintInicio();
            var valor = this.InserirValor();
            return Calculo(resultado, valor);
        }
    }
}
