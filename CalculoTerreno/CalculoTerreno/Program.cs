using System;
using System.Globalization;

namespace CalculoTerreno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OLA. VAMOS INSERIR OS DADOS DO SEU TERRENO ");
            Console.WriteLine();
            Console.WriteLine("DIGITE LARGURA: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("DIGITE O COMPRIMENTO: ");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("DIGITE O VALOR DO METRO QUADRADO: ");
            double precometro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * comprimento;
            double preco = area * precometro;

            Console.WriteLine("ÁREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PREÇO = " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Fim do Programa.");
        }
    }
}
