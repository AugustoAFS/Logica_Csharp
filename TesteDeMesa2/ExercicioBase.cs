using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    internal abstract class ExercicioBase : IExercicio
    {
        protected double ValorPresente {  get; set; }
        protected float TaxaJuros { get; set;}
        protected string? Periodo { get; set; }
        protected int QtdePeriodo { get;set; }
        protected int MesResgate {  get; set; } 
        protected int ValorResgate { get; set; }
        protected double ValorFuturo { get; set; }

        public abstract List<double> Resolver();

        void IExercicio.ColetarDados()
        {   try
            {
                Console.Write("Digite o valor presente R$: ");
                this.ValorPresente = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a taxa de juros (Use , para separ): ");
                this.TaxaJuros = Convert.ToSingle(Console.ReadLine());

                Console.Write("Digite o período: ");
                this.QtdePeriodo = Convert.ToInt32(Console.ReadLine());
                if(this.QtdePeriodo >0)
                {
                    Console.WriteLine("O período está em meses ou anos? (Digite 'meses' ou 'anos')");
                    this.Periodo = Convert.ToString(Console.ReadLine())?.ToLower();

                    Console.WriteLine("Quer fazer algum resgate? (sim ou nao)");
                    string? Resgate = Convert.ToString(Console.ReadLine());

                    if (Resgate == "sim")
                    {
                        Console.Write("Digite o mês de resgate:");
                        this.MesResgate = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Seu saldo é R$ {this.ValorPresente}");
                        Console.Write("Digite quanto quer resgatar:R$ ");
                        this.ValorResgate= Convert.ToInt32(Console.ReadLine());
                    }

                }

                Console.WriteLine("Precisa achar o valor futuro? (sim ou nao)");
                string? Futuro = Convert.ToString(Console.ReadLine());

                if (Futuro == "sim")
                {
                    Console.Write("Digite o valor Futuro:R$ ");
                    this.ValorFuturo = Convert.ToDouble(Console.ReadLine());
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex}.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if (this.Periodo == "anos")
            {
                this.QtdePeriodo *= 12;
                Console.WriteLine($"O período foi convertido para meses: {this.QtdePeriodo} meses.");
            }
            else if (this.Periodo != "meses")
            {
                Console.WriteLine("Unidade de período inválida! Considerando como meses.");
            }
        }
    }
}