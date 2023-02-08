using financeiro.Repositorio;
using financeiro.Service.interfaces;
using System.Globalization;
using System.Text;

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
                ValorDaConta = Decimal.Parse(controleDeContas.ValorDaConta.ToString()),
                DataDePagamento = controleDeContas.DataDePagamento.ToUniversalTime(),
                Pago = false
            };
            _repositorio.IncluirContas(controle);

            return controle;
        }

        public ControleDeContas ObterConta(string nome)
        {
            var conta = new ControleDeContas()
            {
                NomeDaConta = nome
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
            response.Select(x => x.ValorDaConta.ToString("F2", CultureInfo.InvariantCulture));
            return response;
        }

        public string GerarCsv()
        {
            var contas = _repositorio.ObterListaDeContas();

            var csvContent = new StringBuilder();
            csvContent.AppendLine("Id;NomeDaConta;ValorDaConta;Pago;Parcelas");

            foreach (var conta in contas)
            {
                var line = string.Join(";", new string[] {
                    conta.Id.ToString(),
                    conta.NomeDaConta,
                    conta.ValorDaConta.ToString(),
                    conta.Pago.ToString(),
                    conta.Parcelas.ToString()
            });
                csvContent.AppendLine(line);
            }

            return csvContent.ToString();
        }

        public string CalcularPerspectiva(decimal valor)
        {
            var contas = _repositorio.ObterListaDeContas();

            foreach (var conta in contas)
            {
                valor -= conta.ValorDaConta;
            }

            return $"Sua perspectiva é {valor}";
        }
    }
}
