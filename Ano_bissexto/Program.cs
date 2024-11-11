using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ano Bissexto!!");

        int Idade, AnoNascimento;
        DateTime AnoAtual = DateTime.Now;

        List<int> AnoBissexto = new List<int>();

        Console.WriteLine("Informe a sua idade:");
        Idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe seu ano de nascimento:");
        AnoNascimento = Convert.ToInt32(Console.ReadLine());

        for (int i = 2000; i <= AnoAtual.Year; i++)
        {
            if (DateTime.IsLeapYear(i))
            {
                AnoBissexto.Add(i);
            }
        }

        if (AnoBissexto.Contains(AnoNascimento))
        {
            Console.WriteLine("Seu ano de nascimento é um ano bissexto!");
        }
        else
        {
            Console.WriteLine("Seu ano de nascimento não é um ano bissexto.");
        }
    }
}
