namespace Area_Piramide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRIANGULO");
            char repetir;
            double l;
            do
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Digite a base da piramide para calcular a area total da piramide em (mm):");
                    if (double.TryParse(Console.ReadLine(), out l) && l > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida! Por favor, insira um número positivo.");
                    }
                }

                double areaTotal = CalcularAreaPiramide(l);

                Console.WriteLine($"A área total da pirâmide é: {areaTotal:F2} mm²");

                Console.WriteLine("Deseja calcular a area do triangulo novamente? Para continuar (s/S) ou para sair (n/N)");
                repetir = Convert.ToChar(Console.ReadLine());
            } while (repetir == 's' || repetir == 'S');
        }

        static double CalcularAreaPiramide(double l)
        {
            double h_base = (l * Math.Sqrt(3)) / 2;

            double Area_base = (l * l * Math.Sqrt(3)) / 4;

            double h_lateral = 10;

            double Area_h = (l * h_lateral) / 2;

            double Area_total = Area_base + 4 * Area_h;

            return Area_total;
        }
    }
}
