namespace Pesquisa_Linear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 9, 17, 2, 26, 14, 30 };
            char repetir;

            do
            {
                Console.Clear();
                Console.WriteLine("Insira um número para procurar no vetor:");
                int numero = Convert.ToInt32(Console.ReadLine());

                int resultado = Pesquisa(vetor, numero);

                if (resultado != -1)
                {
                    Console.WriteLine($"Número {numero}, encontrado no índice: {resultado}");
                }
                else
                {
                    Console.WriteLine("Numero não encontrado.");
                }

                Console.WriteLine("Deseja verificar novamente se o numero esta no vetor?(s/S ou n/N)");
                repetir = Convert.ToChar(Console.ReadLine());
            } while (repetir == 's' || repetir == 'S');

        }

        static int Pesquisa(int[] vetor, int numero)
        {
            int index = 0;

            foreach (int valor in vetor)
            {
                if (valor == numero)
                {
                    return index;
                }
                index++;
            }

            return -1;
        }
    }
}