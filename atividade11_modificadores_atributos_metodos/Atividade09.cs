
namespace atividade11_modificadores_atributos_metodos
{
    public class Atividade09
    {
        public double resultado = 0;

        public void Inicio()
        {
            EscolherOperacao();
        }
        public void EscolherOperacao()
        {
            string opcao = "";
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Escolha qual operação deseja realizar: ");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Zerar calculadora");
                Console.WriteLine("6 - Para sair");
                opcao = Console.ReadLine();

                Operacao operacao = null;

                switch (opcao)
                {
                    case "1":
                        operacao = new Soma();
                        break;
                    case "2":
                        operacao = new Subtracao();
                        break;
                    case "3":
                        operacao = new Multiplicacao();
                        break;
                    case "4":
                        operacao = new Divisao();
                        break;
                    case "5":
                        operacao = new Zerar();
                        break;
                    default:
                        Console.WriteLine("Calculadora encerrada");
                        break;
                }

                if (operacao != null)
                {
                    resultado = operacao.Executar(resultado);
                    operacao.Print(resultado);
                }

            } while (opcao != "6");
        }
    }
}
