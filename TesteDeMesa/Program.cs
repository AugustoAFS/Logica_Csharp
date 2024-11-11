using TesteDeMesa;

Console.WriteLine("Exercicios Para Teste de Mesa");

char continuar;

do
{
    Console.Clear();
    Console.WriteLine("Escolha um Exercicio para conferir o resultado:");
    Console.WriteLine("1:Exercicio 1\n2:Exercicio 2\n3:Exercicio 3");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch(opcao)
    {
        case 1:
            {
               int[] vetor =  Exercicios.Exercicio1();
                for (int i = 0;i < 4;i++)
                {
                    if (i == 3)Console.WriteLine(vetor[i]);
                    
                }
                break;
            }
        case 2:
            {
                int[] vetor = Exercicios.Exercicio2();
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(vetor[i]);

                }
                break;
            }
        case 3:
            {
                int[] vetor = Exercicios.Exercicio3();
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine(vetor[i]);

                }
                break;
            }
        default:
            {
                break;
            }
    }

    Console.WriteLine("Deseja continuar?(S/N)");
    continuar = Convert.ToChar(Console.ReadLine());
}while (continuar == 'S' || continuar == 's');