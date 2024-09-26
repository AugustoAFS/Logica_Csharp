using System;
using Calculadora;

public class Program
{
    static void Main()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("    Calculadora Simples     ");
        Console.WriteLine("----------------------------");

        Console.WriteLine("Entre com o primeiro número:");
        if (float.TryParse(Console.ReadLine(), out float numero1))
        {
            Console.WriteLine("Entre com o segundo número:");
            if (float.TryParse(Console.ReadLine(), out float numero2))
            {
                Console.WriteLine("Escolha qual operação deseja fazer:\n+ = Adição\n- = Subtração\n* = Multiplicação\n/ = Divisão\n% = Resto");
                char operador = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                Console.WriteLine("Resultado:\n");
                switch (operador)
                {
                    case '+':
                        float resultadoSoma = CalculadoraSimples.Soma(numero1, numero2);
                        Console.WriteLine($"A soma entre os números {numero1} + {numero2} = {resultadoSoma}");
                        break;

                    case '-':
                        float resultadoSubtracao = CalculadoraSimples.Subtracao(numero1, numero2);
                        Console.WriteLine($"A subtração entre os números {numero1} - {numero2} = {resultadoSubtracao}");
                        break;

                    case '/':
                        float resultadoDivisao = CalculadoraSimples.Divisao(numero1, numero2);
                        Console.WriteLine($"A divisão entre os números {numero1} / {numero2} = {resultadoDivisao}");
                        break;

                    case '*':
                        float resultadoMultiplicacao = CalculadoraSimples.Multiplicacao(numero1, numero2);
                        Console.WriteLine($"A multiplicação entre os números {numero1} * {numero2} = {resultadoMultiplicacao}");
                        break;

                    case '%':
                        float resultadoResto = CalculadoraSimples.Resto(numero1, numero2);
                        Console.WriteLine($"O resto entre os números {numero1} % {numero2} = {resultadoResto}");
                        break;

                    default:
                        Console.WriteLine("Operador inválido!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida para o segundo número!");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida para o primeiro número!");
        }

        Console.ReadKey();
    }
}