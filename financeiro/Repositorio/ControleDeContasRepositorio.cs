using financeiro.Repositorio.models;

namespace financeiro.Repositorio
{
    public class ControleDeContasRepositorio : IControleDeContasRepositorio
    {
        private financeiroDbContext _context;
        public ControleDeContasRepositorio(financeiroDbContext context)
        {
            _context = context;
        }
        public ControleDeContas IncluirContas(ControleDeContas controleDeContas)
        {
            _context.ControleDeContas.Add(controleDeContas);
            _context.SaveChanges();

            return controleDeContas;
        }

        public ControleDeContas ObterConta(string nome)
        {
            var response = _context.ControleDeContas.FirstOrDefault(x => x.NomeDaConta == nome);

            return response;
        }

        public void DeletarConta(int id)
        {
            var response = _context.ControleDeContas.FirstOrDefault(x => x.Id == id);
            _context.ControleDeContas.Remove(response);
            _context.SaveChanges();
        }

        public List<ControleDeContas> ObterListaDeContas()
        {
            var response = _context.ControleDeContas.ToList();
            return response;
        }
    }
}
