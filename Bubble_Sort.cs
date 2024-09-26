namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repetir;

            do
            {
                Console.Clear();
                Console.Write("Digite seu nome: ");
                string nomeUsuario = Console.ReadLine();
                int tamanhoVetor = nomeUsuario.Length;

                int[] numeros = new int[tamanhoVetor];

                Console.WriteLine($"\nDigite {tamanhoVetor} números inteiros:");

                int indice = 0;
                foreach (char letra in nomeUsuario)
                {
                    Console.Write("Digite um número: ");
                    numeros[indice] = int.Parse(Console.ReadLine());
                    indice++;
                }

                BubbleSortComFlag(numeros);

                Console.Clear() ;

                Console.WriteLine("\nVetor ordenado (de frente para trás):");
                ImprimirVetor(numeros);

                Console.WriteLine("\nVetor ordenado (de trás para frente):");
                ImprimirVetorInverso(numeros);

                Console.Write("\nDeseja repetir o processo (s/n)? ");
                repetir = Console.ReadLine().ToLower();

            } while (repetir == "s");
        }

        static void BubbleSortComFlag(int[] vetor)
        {
            bool houveTroca;
            do
            {
                houveTroca = false;
                for (int i = 0; i < vetor.Length - 1; i++)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        int temp = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = temp;

                        houveTroca = true;
                    }
                }
            } while (houveTroca);
        }

        static void ImprimirVetor(int[] vetor)
        {
            foreach (int numero in vetor)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }

        static void ImprimirVetorInverso(int[] vetor)
        {
            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
        }
    }
}