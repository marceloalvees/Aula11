namespace mesa_de_trabalho
{
    public class Atividade09
    {
        public double resultado = 0;
        public double valor = 0;
        public string operacao = "";

        public void Inicio()
        {
            EscolherOperacao();
        }
        public void InserirValor(string operacao)
        {
            bool valorValido = false;
            do
            {
                try
                {
                    Console.WriteLine($"Qual valor deseja {operacao}? ");
                    valor = double.Parse(Console.ReadLine());
                    valorValido = true;

                    if (operacao == "Dividir")
                    {
                        if (valor == 0)
                        {
                            valorValido = false;
                            Console.WriteLine("Divisão por 0 não é possível. Digite outro número: ");
                        }
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Você digitou o valor errado. Digite um número");
                }
            } while (!valorValido);
        }
        public void SomarValor(double valor)
        {
            resultado += valor;
        }

        public void SubtrairValor(double valor)
        {
            resultado -= valor;
        }

        public void DividirValor(double valor)
        {
            resultado /= valor;
        }

        public void MultiplicarValor(double valor)
        {
            resultado *= valor;
        }

        public void ZerarResultado()
        {
            resultado = 0;
        }
        public void EscolherOperacao()
        {
            do
            {
                Console.WriteLine("Escolha qual operação deseja realizar: ");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Zerar calculadora");
                Console.WriteLine("6 - Para sair");
                operacao = Console.ReadLine();

                switch (operacao)
                {
                    case "1":
                        Console.WriteLine($"Você digitou 1 - Somar ");
                        InserirValor("Somar");
                        SomarValor(valor);
                        Console.WriteLine($"O resultado é : {resultado} ");
                        break;
                    case "2":
                        Console.WriteLine($"Você digitou 2 - Subtrair ");
                        InserirValor("Subtrair");
                        SubtrairValor(valor);
                        Console.WriteLine($"O resultado é : {resultado} ");
                        break;
                    case "3":
                        Console.WriteLine($"Você digitou 3 - Multiplicar ");
                        InserirValor("Multiplicar");
                        MultiplicarValor(valor);
                        Console.WriteLine($"O resultado é : {resultado} ");
                        break;
                    case "4":
                        Console.WriteLine($"Você digitou 4 - Dividir ");
                        InserirValor("Dividir");
                        if (valor == 0)
                        {
                            Console.WriteLine("Valor inválido. Digite um número: ");
                        }
                        DividirValor(valor);
                        Console.WriteLine($"O resultado é : {resultado} ");
                        break;
                    case "5":
                        Console.WriteLine($"Você digitou 5 - Zerar ");
                        ZerarResultado();
                        Console.WriteLine($"O resultado é : {resultado} ");
                        break;
                    default:
                        Console.WriteLine("Calculadora encerrada");
                        break;
                }

                Console.WriteLine("");

            } while (operacao != "6");
        }
    }
}
