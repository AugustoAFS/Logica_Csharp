using System;
using System.Collections.Generic;

namespace TesteDeMesa3._1
{
    public abstract class ExercicioBase
    {
        protected List<decimal>? ValorPresente { get; set; } = new List<decimal>();
        protected List<decimal>? TaxaJuros { get; set; } = new List<decimal>();
        protected int PeriodoMes { get; set; }
        protected int PeriodoDia { get; set; }
        protected List<List<(decimal ValorInvestido, decimal TaxaJuros, int DiasTotais, decimal Rendimento)>> Tabelas { get; set; } = new List<List<(decimal ValorInvestido, decimal TaxaJuros, int DiasTotais, decimal Rendimento)>>();

        public abstract void ColetarDados();
        public abstract void RealizarExercicio();
        public abstract void MostrarTabela();
        public abstract void RealizarResgate();
    }
}