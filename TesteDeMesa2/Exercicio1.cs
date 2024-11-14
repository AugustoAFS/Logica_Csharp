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

            for (int i = 1; i <= QtdePeriodo; i++)
            {
                double Resultado = ValorPresente * Math.Pow((1 + TaxaJuros), i);
                resultado.Add(Resultado);
            }

            return resultado;
        }
    }
}
