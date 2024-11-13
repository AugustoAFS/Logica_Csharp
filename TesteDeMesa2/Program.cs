using System;
using TesteDeMesa2;

public class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Escolha um exercício para resolver (1 a 5) ou digite 0 para sair:");

            int escolha = Convert.ToInt32(Console.ReadLine());
            IExercicio exercicio = null;

            switch (escolha)
            {
                case 1:
                    exercicio = new Exercicio1();

                    exercicio.ColetarDados();

                    List<double> resultados = exercicio.Resolver();

                    Console.WriteLine("Resultados dos cálculos:");
                    foreach (var resultado in resultados)
                    {
                        Console.WriteLine($"Valor futuro: R${resultado:F2}");
                    }

                    break;
                case 2:
                    exercicio = new Exercicio2();
                    break;
                case 3:
                    exercicio = new Exercicio3();
                    break;
                case 4:
                    exercicio = new Exercicio4();
                    break;
                case 5:
                    exercicio = new Exercicio5();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    continue;
            }
            exercicio.ColetarDados();

            double resultado = exercicio.Resolver();
            Console.WriteLine($"Resultado: R$ {resultado}");

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
