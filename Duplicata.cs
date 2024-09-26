using System.Collections.Generic;
namespace Duplicata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duplicata");
            int[] numerosComDuplicatas = { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 };

            List<int> numerosSemDuplicatas = RemoverDuplicata(numerosComDuplicatas);

            Console.WriteLine("Números não duplicatas:");
            foreach (int numero in numerosSemDuplicatas)
            {
                Console.Write(numero + " ");
            }
            Console.ReadLine();
        }

        static List<int> RemoverDuplicata(int[] numeros)
        {
            List<int> resultado = new List<int>();

            foreach (int numero in numeros)
            {
                if (!resultado.Contains(numero))
                {
                    resultado.Add(numero);
                }
            }

            return resultado;
        }
    }
}