using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    internal class Exercicio4 : ExercicioBase
    {
        private int mesResgate;

        public void ColetarDados()
        {
            base.ColetarDados();
            Console.Write("Digite o mês de resgate (se houver): ");
            mesResgate = Convert.ToInt32(Console.ReadLine());
        }

        public override double Resolver()
        {
            double rendimento = valorPresente * Math.Pow((1 + taxaJuros), periodo);

            if (mesResgate == 5)
            {
                rendimento = valorPresente + (rendimento - valorPresente) / 2;
            }

            return rendimento;
        }
    }
}
