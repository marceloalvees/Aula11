namespace atividade11_modificadores_atributos_metodos
{
    public class ListaDeFilmes: Lista
    {
        String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

        public override string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
        {
            string filmes = "";
            for (int i = 0; i < listaDeFilmes.Length; i++)
            {
                    filmes = filmes + $"{listaDeFilmes[i]}; ";
            }
            return filmes;
        }
        public override int quantidadeTotalDeFilmes()
        {
            return listaDeFilmes.Length;
        }
        public override string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
        {
            string filme = listaDeFilmes[indiceDoFilme];
            return filme;
        }
        public override string[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
        {
            int novoTamanho = listaDeFilmes.Length + 1;

            string[] novaLista = new string[novoTamanho];

            for (int i = 0; i < listaDeFilmes.Length; i++)
                novaLista[i] = listaDeFilmes[i];

            novaLista[novoTamanho - 1] = nomeDoFilme;

            return novaLista;
        }
        public override string[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme)
        {
            Console.WriteLine("Qual filme você deseja colocar nesse índice?");
            string filme = Console.ReadLine();
            listaDeFilmes[indiceDoFilme] = filme;
            Console.WriteLine($"O filme inserido no índice escolhido {indiceDoFilme} é: {filme}, e foi atualizado com sucesso!");
            return listaDeFilmes;
        }
        public override string[] listarTodosOsFilmesComSeuIndiceNaLista()
        {
            for (int i = 0; i < listaDeFilmes.Length; i++)
            {
                Console.WriteLine($"{i} - {listaDeFilmes[i]}");

            }
            return listaDeFilmes;
        }
    }
}
