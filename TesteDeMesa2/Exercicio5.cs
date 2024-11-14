using System;
using System.Collections.Generic;

namespace TesteDeMesa2
{
    internal class Exercicio5 : ExercicioBase
    {
        public override List<double> Resolver()
        {
            List<double> resultado = new List<double>();

            Console.WriteLine("\nvalorPresente\t\ttaxaJuros\tperiodoMes\tvalor F"); 
            
            if (this.ValorFuturo > 0 && this.ValorPresente > 0 && this.TaxaJuros > 0)
            {
                var n = Math.Log(this.ValorFuturo / this.ValorPresente) / Math.Log(1 + this.TaxaJuros / 100);
                this.QtdePeriodo = (int)n;

            }
            
            for (int i = 1; i <= this.QtdePeriodo; i++)
            {
                double valorFuturo = this.ValorPresente * Math.Pow((1 + (this.TaxaJuros / 100)), i);
                resultado.Add(valorFuturo);

                Console.WriteLine($"R$ {this.ValorPresente,10:N2}\t\t{this.TaxaJuros:F2}%\t\t{i}\t\tR$ {valorFuturo,10:N2}");
            }
           
            




            return resultado;
        }
    }
}
