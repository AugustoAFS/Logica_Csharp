using System;

namespace TesteDeMesa3._1
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Problema problema = new();

            while (true)
            {
                Console.WriteLine("Selecione o problema para resolver:");
                Console.WriteLine("1 - Calcular Rendimento Futuro");
                Console.WriteLine("2 - Calcular Resgate e Saldo Líquido");
                Console.WriteLine("3 - Mostrar Tabela de Dados");
                Console.WriteLine("4 - Sair");
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");

                switch (opcao)
                {
                    case 1:
                        problema.ColetarDados();
                        problema.RealizarExercicio();
                        break;
                    case 2:
                        problema.RealizarResgate();
                        break;
                    case 3:
                        problema.MostrarTabela();
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
