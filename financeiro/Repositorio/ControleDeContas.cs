namespace financeiro
{
    public class ControleDeContas
    {
        public int Id { get; set; }
        public string NomeDaConta { get; set; }
        public int ValorDaConta { get; set; }
        public DateTime DataDePagamento { get; set; }
        public bool Pago { get; set; }
        public int Parcelas { get; set; }
    }
}
