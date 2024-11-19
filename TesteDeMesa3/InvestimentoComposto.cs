namespace TesteDeMesa3
{
    public class InvestimentoComposto : InvestimentoBase
    {
        public InvestimentoComposto(decimal valorPresente, float taxaJuros, int meses)
            : base(valorPresente, taxaJuros, meses)
        { }

        public override decimal CalcularRendimentoFuturo()
        {
            float taxaMensal = TaxaJuros / 100 / 12;
            decimal valorFuturo = ValorPresente * (decimal)Math.Pow(1 + taxaMensal, Meses);
            return valorFuturo;
        }
    }
}
