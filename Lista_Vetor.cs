namespace Lista_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista1 = new List<int>(90);
            List<int> lista2 = new List<int>(90);

            PreencherLista(lista1, 90);
            PreencherLista(lista2, 90);

            List<int> listaIntercalada = Intercalar(lista1, lista2);

            int soma = 0;
            foreach (int valor in listaIntercalada)
            {
                soma += valor;
            }

            double media = (double)soma / listaIntercalada.Count;

            Console.WriteLine("Lista 1: " + string.Join(", ", lista1));
            Console.WriteLine("\nLista 2: " + string.Join(", ", lista2));
            Console.WriteLine("\nLista intercalada:");
            Console.WriteLine(string.Join(", ", listaIntercalada));
            Console.WriteLine($"\nSoma da lista intercalada: {soma}");
            Console.WriteLine($"\nMédia da lista intercalada: {media}");
        }

        static void PreencherLista(List<int> lista, int quantidade)
        {
            Random random = new Random();
            for (int i = 0; i < quantidade; i++)
            {
                lista.Add(random.Next(1, 101));
            }
        }
        static List<int> Intercalar(List<int> lista1, List<int> lista2)
        {
            List<int> resultado = new List<int>();
            int tamanho = Math.Min(lista1.Count, lista2.Count);

            using (IEnumerator<int> enumerador1 = lista1.GetEnumerator(),enumerador2 = lista2.GetEnumerator())
            {
                for (int i = 0; i < tamanho; i++)
                {
                    enumerador1.MoveNext();
                    resultado.Add(enumerador1.Current);

                    enumerador2.MoveNext();
                    resultado.Add(enumerador2.Current);
                }
            }
            return resultado;
        }
    }
}