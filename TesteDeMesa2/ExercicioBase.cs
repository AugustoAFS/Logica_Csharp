using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDeMesa2;

public abstract class ExercicioBase : IExercicio
{
    protected double valorPresente;
    protected double taxaJuros;
    protected int periodo; 

    public void ColetarDados()
    {
        Console.Write("Digite o valor presente (R$): ");
        valorPresente = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a taxa de juros (%): ");
        taxaJuros = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Digite o período: ");
        periodo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("O período está em meses ou anos? (Digite 'meses' ou 'anos')");
        string unidadePeriodo = Console.ReadLine().ToLower();

        if (unidadePeriodo == "anos")
        {
            periodo *= 12;
            Console.WriteLine($"O período foi convertido para meses: {periodo} meses.");
        }
        else if (unidadePeriodo != "meses")
        {
            Console.WriteLine("Unidade de período inválida! Considerando como meses.");
        }
    }

    public abstract List<double> Resolver();

    List<double> IExercicio.Resolver()
    {
        throw new NotImplementedException();
    }
}
