using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa
{
    internal class Exercicios
    {
        public static int[] Exercicio1()
        {
            int a = 10; 
            int b = 20;
            int c = ((a + b) / 2);
            c -= 40;
            int resultado = (a + b) + c;
            int[] vetor = new int[5];
            for (int i = 0; i <= 4; i++)
            {
               
                if (i == 3)
                {
                    vetor[i] = resultado;
                }
                else
                {
                    vetor[i] = 0;
                }
                
            }

            return vetor;
        }
        public static int[] Exercicio2() 
        {
            int a = 2;
            int[] vetor = new int[6];
            while (a < 6)
            {
                vetor[a] = 10 * a; 
                a++;
            }
            return vetor;
        }

        public static int[] Exercicio3() 
        {
            int a = 7;
            int b = a - 6;
            int[] vetor = new int[8];
            while (b < a)
            {
                vetor[b] = b + a;
                b += 2;
            }
            return vetor;
        }
    }
}
