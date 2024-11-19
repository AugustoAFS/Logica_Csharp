using System;
using System.Collections.Generic;

namespace TesteDeMesa3._1
{
    class Problema : ExercicioBase
    {
        public override void ColetarDados()
        {
            Console.WriteLine("Digite os valores presentes investidos separados por vírgula (ex: 1000, 5500, 12000):");
            string entradaValores = Console.ReadLine();
            foreach (var valor in entradaValores.Split(','))
            {
                if (decimal.TryParse(valor.Trim(), out decimal valorDecimal))
                {
                    ValorPresente.Add(valorDecimal);
                }
                else
                {
                    Console.WriteLine($"Valor inválido ignorado: {valor}");
                }
                
            }

            Console.WriteLine("Digite as taxas de juros (%) separadas por vírgula ou ponto (ex: 3, 2.48, 2):");
            string entradaTaxas = Console.ReadLine();
            foreach (var taxa in entradaTaxas.Split(','))
            {
                string taxaCorrigida = taxa.Trim().Replace('.', ',');
                if (decimal.TryParse(taxaCorrigida, out decimal taxaDecimal))
                {
                    TaxaJuros.Add(taxaDecimal / 100);
                }
                else
                {
                    Console.WriteLine($"Taxa inválida ignorada: {taxa}");
                }
            }

            Console.Write("Digite o período em meses: ");
            PeriodoMes = int.Parse(Console.ReadLine());
            Console.Write("Digite o período adicional em dias: ");
            PeriodoDia = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        public override void RealizarExercicio()
        {
            int totalDias = (PeriodoMes * 30) + PeriodoDia;

            Console.WriteLine("\nGerando tabelas...");
            foreach (var valor in ValorPresente)
            {
                var tabela = new List<(decimal ValorInvestido, decimal TaxaJuros, int DiasTotais, decimal Rendimento)>();

                foreach (var taxa in TaxaJuros)
                {
                    decimal taxaDiaria = taxa / 30;
                    decimal rendimentoFuturo = valor * (decimal)Math.Pow((1 + (double)taxaDiaria), totalDias);
                    tabela.Add((valor, taxa * 100, totalDias, rendimentoFuturo));
                }

                Tabelas.Add(tabela);
            }
            Console.Clear();
            Console.WriteLine("Tabelas geradas com sucesso!\n\n");

        }

        public override void RealizarResgate()
        {
            if (Tabelas.Count == 0)
            {
                Console.WriteLine("Nenhuma tabela disponível para resgate.");
                return;
            }

            Console.WriteLine("Escolha uma tabela para realizar o resgate:");
            for (int i = 0; i < Tabelas.Count; i++)
            {
                Console.WriteLine($"Tabela {i + 1}: Valor Presente = {Tabelas[i][0].ValorInvestido:C}");
            }

            Console.Write("Digite o número da tabela: ");
            int tabelaEscolhida = int.Parse(Console.ReadLine()) - 1;

            if (tabelaEscolhida < 0 || tabelaEscolhida >= Tabelas.Count)
            {
                Console.WriteLine("Tabela inválida.");
                return;
            }

            var tabela = Tabelas[tabelaEscolhida];

            Console.WriteLine("\nTabela Selecionada:");
            Console.WriteLine("Valor Investido\tTaxa de Juros\tDias Totais\tRendimento Futuro");
            foreach (var linha in tabela)
            {
                Console.WriteLine($"{linha.ValorInvestido:C}\t\t{linha.TaxaJuros:F2}%\t\t{linha.DiasTotais}\t\t{linha.Rendimento:C}");
            }

            decimal saldoAtual = tabela[0].Rendimento;

            Console.Write("Digite o mês de resgate: ");
            int mesResgate = int.Parse(Console.ReadLine());

            if (mesResgate < 1 || mesResgate > PeriodoMes)
            {
                Console.WriteLine("Mês de resgate inválido.");
                return;
            }

            Console.WriteLine("\nGerando tabela com os valores mês a mês para cada taxa de juros:");
            List<decimal> rendimentosMensais = new List<decimal>();

            foreach (var linha in tabela)
            {
                decimal rendimentoMensal = linha.Rendimento;
                decimal taxaDiaria = linha.TaxaJuros / 30;

                Console.WriteLine($"\nCalculando para a taxa de {linha.TaxaJuros:F2}%");

                for (int mes = 1; mes <= mesResgate; mes++)
                {
                    rendimentoMensal = rendimentoMensal * (1 + taxaDiaria);
                    Console.WriteLine($"Mês {mes}: Rendimento = {rendimentoMensal:C}");
                }

                rendimentosMensais.Add(rendimentoMensal);
            }

            Console.WriteLine("\nEscolha a taxa de juros para o resgate:");
            for (int i = 0; i < TaxaJuros.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {TaxaJuros[i] * 100:F2}%");
            }

            Console.Write("Digite o número da taxa de juros para o resgate: ");
            int taxaEscolhida = int.Parse(Console.ReadLine()) - 1;

            if (taxaEscolhida < 0 || taxaEscolhida >= TaxaJuros.Count)
            {
                Console.WriteLine("Taxa de juros inválida.");
                return;
            }

            decimal saldoFinal = rendimentosMensais[taxaEscolhida];

            Console.WriteLine($"\nSaldo Atual: {saldoFinal:C}");
            Console.Write("Digite o valor que deseja resgatar: ");
            decimal valorResgate = decimal.Parse(Console.ReadLine());

            if (valorResgate > saldoFinal)
            {
                Console.WriteLine("O valor de resgate excede o saldo disponível.");
                return;
            }

            decimal saldoRestante = saldoFinal - valorResgate;
            Console.WriteLine($"Resgate realizado com sucesso! Saldo Restante após o resgate: {saldoRestante:C}");
            Console.WriteLine("\n\n");

            tabela[0] = (tabela[0].ValorInvestido, tabela[0].TaxaJuros, tabela[0].DiasTotais, saldoRestante);
        }

        public override void MostrarTabela()
        {
            for (int i = 0; i < Tabelas.Count; i++)
            {
                Console.WriteLine($"\nTabela {i + 1}:");
                Console.WriteLine("Valor Investido\tTaxa de Juros\tDias Totais\tRendimento Futuro");

                foreach (var linha in Tabelas[i])
                {
                    Console.WriteLine($"{linha.ValorInvestido:C}\t\t{linha.TaxaJuros:F2}%\t\t{linha.DiasTotais}\t\t{linha.Rendimento:C}");
                }
            }
        }
    }
}
