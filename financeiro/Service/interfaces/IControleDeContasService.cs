namespace financeiro.Service.interfaces
{
    public interface IControleDeContasService
    {
        ControleDeContas IncluirContas(ControleDeContas controleDeContas);
        ControleDeContas ObterConta(string nome);
        string DeletarConta(int id);
        List<ControleDeContas> ObterListaDeContas();
        string GerarCsv();
        string CalcularPerspectiva(decimal valor);
    }
}
