using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    internal abstract class ExercicioBase : IExercicio
    {
        protected double ValorPresente {  get; set; }
        protected double TaxaJuros { get; set;}
        protected string? Periodo { get; set; }
        protected int QtdePeriodo { get;set; }

        public abstract List<double> Resolver();

        void IExercicio.ColetarDados()
        {
            Console.Write("Digite o valor presente (R$): ");
            ValorPresente = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de juros (Use . para separ): ");
            TaxaJuros = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o período: ");
            QtdePeriodo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O período está em meses ou anos? (Digite 'meses' ou 'anos')");
            Periodo = Console.ReadLine().ToLower();

            if (Periodo == "anos")
            {
                QtdePeriodo *= 12;
                Console.WriteLine($"O período foi convertido para meses: {QtdePeriodo} meses.");
            }
            else if (Periodo != "meses")
            {
                Console.WriteLine("Unidade de período inválida! Considerando como meses.");
            }
        }
    }
}
