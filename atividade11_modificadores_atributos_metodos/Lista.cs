namespace atividade11_modificadores_atributos_metodos
{
    public abstract class Lista
    {
        public abstract string  apresentaTodosOsFilmesSeparadosPorPontoVirgula();
        public abstract int quantidadeTotalDeFilmes();
        public abstract string buscarNomeDoFilmePeloIndice(int indiceDoFilme);
        public abstract string[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme);
        public abstract string[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme);
        public abstract string[] listarTodosOsFilmesComSeuIndiceNaLista();



    }
}
