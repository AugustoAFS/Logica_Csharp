using System;
using System.Collections.Generic;

namespace TesteDeMesa3
{
    public abstract class InvestimentoBase
    {
        public decimal ValorPresente { get; set; }
        public float TaxaJuros { get; set; }
        public int Meses { get; set; }

        public InvestimentoBase(decimal valorPresente, float taxaJuros, int meses)
        {
            ValorPresente = valorPresente;
            TaxaJuros = taxaJuros;
            Meses = meses;
        }

        public abstract decimal CalcularRendimentoFuturo();
    }
}
