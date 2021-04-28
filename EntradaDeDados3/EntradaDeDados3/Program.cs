using System;
using System.Globalization;

namespace EntradaDeDados3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int bedrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("entre seu último nome, idade e altura (mesma linha): ");
            string[] dados = Console.ReadLine().Split(' ');
            string lastName = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(firstName);
            Console.WriteLine(bedrooms);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("FIM DO PROGRAMA.");
            Console.ReadLine();
        }
    }
}
