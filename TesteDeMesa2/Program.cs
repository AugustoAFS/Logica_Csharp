using System.Security.Cryptography.X509Certificates;

namespace TesteDeMesa2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Escolha qual exercicio quer fazer de 1 a 5 ou 0 para sair.");
                int opcao = Convert.ToInt32(Console.ReadLine());
                IExercicio? exercicio = null;

                switch (opcao)
                {
                    case 1:
                        {
                            exercicio = new Exercicio1();
                            exercicio.ColetarDados();
                            List<double> resultado = exercicio.Resolver();
                            break;
                        }
                    case 2:
                        {
                            exercicio = new Exercicio2();
                            exercicio.ColetarDados();
                            List<double> resultado = exercicio.Resolver();
                            break;
                        }
                    case 3:
                        {
                            exercicio = new Exercicio3();
                            exercicio.ColetarDados();
                            List<double> resultado = exercicio.Resolver();
                            break;
                        }
                    case 4:
                        {
                            exercicio = new Exercicio4();
                            exercicio.ColetarDados();
                            List<double> resultado = exercicio.Resolver();
                            break;
                        }
                    case 5:
                        {
                            exercicio = new Exercicio5();
                            exercicio.ColetarDados();
                            List<double> resultado = exercicio.Resolver();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Saindo...");
                            continuar = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Escolha inválida. Tente novamente.");
                            continue;
                        }
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }   
    }
}
