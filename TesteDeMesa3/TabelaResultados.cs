using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa3
{
    public class TabelaResultados
    {
        public static void ExibirTabela(List<(decimal ValorInvestido, decimal TaxaJuros, decimal Rendimento, int Periodo, decimal Resgate, decimal SaldoLiquido)> dados)
        {
            Console.WriteLine("\nValor Investido\tTaxa de Juros\tRendimento\tPeríodo (meses)\tResgate\tSaldo Líquido");
            Console.WriteLine(new string('-', 80));
            foreach (var item in dados)
            {
                Console.WriteLine($"{item.ValorInvestido:C}\t\t{item.TaxaJuros:F2}%\t\t{item.Rendimento:C}\t{item.Periodo} meses\t\t{item.Resgate:C}\t{item.SaldoLiquido:C}");
            }
        }
    }
}