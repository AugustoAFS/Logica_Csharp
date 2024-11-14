using System;
using System.Collections.Generic;

namespace TesteDeMesa2
{
    internal class Exercicio4 : ExercicioBase
    {
        public override List<double> Resolver()
        {
            List<double> resultado = new List<double>();

            Console.WriteLine("\nvalorPresente\t\ttaxaJuros\tperiodoMes\tvalor F");
            for (int i = 1; i <= this.QtdePeriodo; i++)
            {
                double valorFuturo = this.ValorPresente * Math.Pow((1 + (this.TaxaJuros / 100)), i);
                resultado.Add(valorFuturo);

                if (i == this.MesResgate)
                {
                    this.ValorPresente = valorFuturo;
                    this.ValorPresente -= this.ValorResgate;
                    valorFuturo = this.ValorPresente;
                }

                Console.WriteLine($"R$ {ValorPresente,10:N2}\t\t{TaxaJuros:F2}%\t\t{i}\t\tR$ {valorFuturo,10:N2}");
            }
            return resultado;
        }
    }
}
