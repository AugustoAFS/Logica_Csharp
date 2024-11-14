using System.Security.Cryptography.X509Certificates;

namespace TesteDeMesa2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Escolha qual exercicio quer fazer de 1 a 5");
            int opcao = Convert.ToInt32(Console.ReadLine());
            IExercicio? exercicio = null;
            
            switch (opcao)
            {
                case 1:
                    {
                        exercicio = new Exercicio1();
                        exercicio.ColetarDados();
                        List<double> resultado = exercicio.Resolver();
                        foreach (double dado in resultado)
                        {
                            Console.WriteLine($"Resultado: R$ {dado:F2}");
                        }
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                 default:
                    {
                        break;
                    }
            }
            
        }
    }
}
