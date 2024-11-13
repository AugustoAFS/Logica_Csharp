using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    public class Exercicio1 : ExercicioBase
    {
        public override List<double> Resolver()
        {
            List<double> valorResultado = new List<double>();
            for (int i = 1; i <= periodo; i++)
            {
                double resultado = valorPresente * Math.Pow(1 + taxaJuros, i);
                valorResultado.Add(resultado);
            }
            return valorResultado;
        }
    }
}


