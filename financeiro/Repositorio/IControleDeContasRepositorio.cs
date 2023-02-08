namespace financeiro.Repositorio
{
    public interface IControleDeContasRepositorio
    {
        ControleDeContas IncluirContas(ControleDeContas controleDeContas);
        ControleDeContas ObterConta(string nome);
        void DeletarConta(int id);
        List<ControleDeContas> ObterListaDeContas();
    }
}
