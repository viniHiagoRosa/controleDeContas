using financeiro.Repositorio;
using financeiro.Service.interfaces;

namespace financeiro.Service
{
    public class ControleDeContasService : IControleDeContasService
    {
        private readonly IControleDeContasRepositorio _repositorio;

        public ControleDeContasService(IControleDeContasRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public ControleDeContas IncluirContas(ControleDeContas controleDeContas)
        {
            var controle = new ControleDeContas()
            {
                NomeDaConta = controleDeContas.NomeDaConta.ToUpper(),
                ValorDaConta = controleDeContas.ValorDaConta,
                DataDePagamento = controleDeContas.DataDePagamento,
                Pago = false
            };
            _repositorio.IncluirContas(controle);

            return controle;
        }

        public ControleDeContas ObterConta(string nome)
        {
            var conta = new ControleDeContas()
            {
                NomeDaConta = nome.ToUpper()
            };
            _repositorio.ObterConta(conta.NomeDaConta);
            return conta;
        }
        public string DeletarConta(int id)
        {
            _repositorio.DeletarConta(id);

            return $" Id {id} deletado";
        }
        public List<ControleDeContas> ObterListaDeContas()
        {
            var response = _repositorio.ObterListaDeContas();
            response.Select(x => x.NomeDaConta).ToList();

            return response;
        }
    }
}
