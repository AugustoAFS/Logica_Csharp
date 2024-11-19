namespace TesteDeMesa3
{
    public class InvestimentoComResgate : InvestimentoComposto
    {
        public InvestimentoComResgate(decimal valorPresente, float taxaJuros, int meses)
            : base(valorPresente, taxaJuros, meses)
        { }

        public decimal CalcularResgateNoMes(int mes)
        {
            if (mes > Meses) throw new ArgumentException("Mês de resgate maior que o período.");

            float taxaMensal = TaxaJuros / 100 / 12;
            decimal valorResgatado = ValorPresente * (decimal)Math.Pow(1 + taxaMensal, mes);
            return valorResgatado;
        }

        public decimal CalcularSaldoRestante()
        {
            decimal valorFuturo = CalcularRendimentoFuturo();
            decimal resgate = CalcularResgateNoMes(5);
            return valorFuturo - resgate;
        }
    }
}
