using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    internal class Exercicio2 : ExercicioBase
    {
        public override double Resolver()
        {
            return valorPresente * (1 + taxaJuros * periodo);
        }
    }
}
