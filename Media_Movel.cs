namespace Media_Movel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média movel simples");
            Console.WriteLine();
            char continuar;
            do
            {
                Console.Clear();
                Console.WriteLine("Insira o tamanho do vetor (inteiro positivo maior que 1):");
                int x = int.Parse(Console.ReadLine());
                while (x <= 1)
                {
                    Console.Clear();
                    Console.WriteLine("Por favor insira o tamanho do vetor (inteiro positivo maior que 1 ou -1 para encerrar a operação):");
                    x = int.Parse(Console.ReadLine());
                    if (x == -1)
                    {
                        Console.WriteLine("Calculo da média simples interronpido pelo usuário");
                        return;
                    }
                }
                    int[] ListaResultadoAleatorio = GerarVetorAleatorio(x);

                Console.WriteLine();
                Console.WriteLine("Insira a quantidade de elementos que será pego para realizar a média (inteiro positivo maior que 1):");
                int y = int.Parse(Console.ReadLine());
                while (y <= 1)
                {
                    Console.Clear();
                    Console.WriteLine("Insira a quantidade de elementos que será pego para realizar a média (inteiro positivo maior que 1 ou -1 para emcerrar a operação):");
                    y = int.Parse(Console.ReadLine());
                    if (y == -1)
                    {
                        Console.WriteLine("Calculo da média simples interronpido pelo usuário");
                        return;
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Vetor de dados:");
                foreach (int i in ListaResultadoAleatorio)
                {
                    Console.Write($"{i}\t");
                }
                Console.WriteLine();
                int [] ListaResultadoMedia = MediaDadosVetor(ListaResultadoAleatorio, x, y);
                Console.WriteLine();
                Console.WriteLine("Vetor resultante:");
                foreach (int i in ListaResultadoMedia)
                {
                    Console.Write($"{i}\t");
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Deseja testar novamento (s ou n)?");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar == 's' || continuar == 'S');
        }

        private static int[] GerarVetorAleatorio(int tamanho)
        {
            Random random = new();

            int NumerosVetor = random.Next(1,101);
            int[] Lista = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Lista[i] = random.Next(1, 101);
            }

            return Lista;
        }

        private static int[] MediaDadosVetor(int[] vetor, int tamanho, int janela)
        {
            int[] Resultado = new int[tamanho - janela + 1];

            for (int i = 0; i <= tamanho - janela; i++)
            {
                int soma = 0;
                for (int j = 0; j < janela; j++)
                {
                    soma += vetor[i + j];
                }
                Resultado[i] = soma / janela;
            }

            return Resultado;
        }
    }
}
