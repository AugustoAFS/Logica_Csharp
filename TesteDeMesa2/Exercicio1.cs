using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    internal class Exercicio1 : ExercicioBase
    {
        public override List<double> Resolver()
        {
            List<double> resultado = new List<double>();

            Console.WriteLine("\nvalorPresente\t\ttaxaJuros\tperiodoMes\tvalor F");
            for (int i = 1; i <= this.QtdePeriodo; i++)
            {
                double valorFuturo = this.ValorPresente * Math.Pow((1 + (this.TaxaJuros/100)), i);
                resultado.Add(valorFuturo);

                Console.WriteLine($"R$ {ValorPresente,10:N2}\t\t{TaxaJuros:F2}%\t\t{i}\t\tR$ {valorFuturo,10:N2}");
            }
            return resultado;
        }
    }
}
