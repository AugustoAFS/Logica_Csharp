namespace TesteDeMesa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Calcular Rendimento Futuro");
                Console.WriteLine("2. Calcular Resgate no 5º Mês");
                Console.WriteLine("3. Exibir Tabela de Resultados");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 4)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }

                switch (opcao)
                {
                    case 1:
                        CalcularRendimentoFuturo();
                        break;

                    case 2:
                        CalcularResgate();
                        break;

                    case 3:
                        ExibirTabela();
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void CalcularRendimentoFuturo()
        {
            decimal[] valoresPresentes = { 1000m, 5500m, 12000m };
            float[] taxasJuros = { 3.0f, 2.48f, 2.0f };
            int meses = 8;

            Console.WriteLine("Rendimento Futuro:");

            for (int i = 0; i < valoresPresentes.Length; i++)
            {
                InvestimentoComposto investimento = new InvestimentoComposto(valoresPresentes[i], taxasJuros[i], meses);
                decimal rendimentoFuturo = investimento.CalcularRendimentoFuturo();
                Console.WriteLine($"Valor Inicial: R$ {valoresPresentes[i]}, Taxa: {taxasJuros[i]}%, Rendimento Futuro: R$ {rendimentoFuturo:F2}");
            }
        }

        static void CalcularResgate()
        {
            decimal[] valoresPresentes = { 1000m, 5500m, 12000m };
            float[] taxasJuros = { 3.0f, 2.48f, 2.0f };
            int meses = 8;

            Console.WriteLine("Resgates no 5º Mês:");

            for (int i = 0; i < valoresPresentes.Length; i++)
            {
                InvestimentoComResgate investimento = new InvestimentoComResgate(valoresPresentes[i], taxasJuros[i], meses);
                decimal resgate = investimento.CalcularResgateNoMes(5);
                decimal saldoRestante = investimento.CalcularSaldoRestante();
                Console.WriteLine($"Valor Inicial: R$ {valoresPresentes[i]}, Taxa: {taxasJuros[i]}%, Resgate: R$ {resgate:F2}, Saldo Restante: R$ {saldoRestante:F2}");
            }
        }

        static void ExibirTabela()
        {
            decimal[] valoresPresentes = { 1000m, 5500m, 12000m };
            float[] taxasJuros = { 3.0f, 2.48f, 2.0f };
            int meses = 8;

            Console.WriteLine("Tabela de Resultados:");

            Console.WriteLine("| Valor Investido | Taxa de Juros | Rendimento | Período (meses) | Resgate | Saldo Líquido |");
            Console.WriteLine("|-----------------|---------------|------------|-----------------|---------|---------------|");

            for (int i = 0; i < valoresPresentes.Length; i++)
            {
                InvestimentoComResgate investimento = new InvestimentoComResgate(valoresPresentes[i], taxasJuros[i], meses);
                decimal rendimentoFuturo = investimento.CalcularRendimentoFuturo();
                decimal resgate = investimento.CalcularResgateNoMes(5);
                decimal saldoRestante = investimento.CalcularSaldoRestante();

                Console.WriteLine($"| {valoresPresentes[i],-15} | {taxasJuros[i],-13} | {rendimentoFuturo,-10:F2} | {meses,-15} | {resgate,-7:F2} | {saldoRestante,-13:F2} |");
            }
        }
    }
}
