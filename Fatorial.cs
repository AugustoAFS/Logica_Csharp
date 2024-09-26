namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatorial");
            List<long> Numeros = new();
            List<int> Sequencia = new();

            int Numero = 2, sequencia = 224;
            long FAT = 0;
            long somaFAT = 0;

            for (int i = Numero; i <= 10; i++)
            {
                Numeros.Add(Fatorial(i));
            }

            for (int i = 2; i <= 10; i++)
            {
                Sequencia.Add(sequencia);
                sequencia += 4;
            }

            //Console.WriteLine("Resultados FAT:");
            for (int i = 0; i < Numeros.Count; i++)
            {
                FAT = Sequencia[i] / Numeros[i];
               //Console.WriteLine($"FAT[{i}] = {Sequencia[i]} / {Numeros[i]} = {FAT}");
                somaFAT += FAT;
            }

            Console.WriteLine($"\nSomatório dos resultados FAT: {somaFAT}");
        }

        static long Fatorial(int Numero)
        {
            long Fatorial = 1;
            for (int i = 1; i <= Numero; i++)
            {
                long nu = i;
                Fatorial *= nu;
            }
            return Fatorial;
        }
    }
}
